using GeniyIdiot.Common;
using System;
using System.IO;
using System.Linq;
using System.Timers;

class Program
{
    static Game game;
    static void Main(string[] args)
    {
        game = new Game(new User(GetUserName()), new QuestionsStorage(), new DiagnosesStorage());
        var questionsStorage = game.QuestionsStorage;

        Console.WriteLine($"{game.User.Name}, вы хотите начать тест? Введите \"Да\" или \"Нет\".");
        bool start = Apply(game.User);

        while (start)
        {
            StartTest(game);

            // вывод количества правильных ответов и диагноза
            Console.WriteLine("Количество правильных ответов: " + game.User.RightAnswersCount);

            Console.WriteLine($"{game.User.Name}, ваш диагноз: {game.User.Diagnose.Grade}");

            // запрос у пользователя на сохранение результатов теста
            Console.WriteLine("Хотите сохранить результаты теста? Введите \"Да\" или \"Нет\".");

            if (Apply(game.User))
            {
                game.User.SaveTestResult();
                Console.WriteLine("Результаты теста успешно сохранены.");
            }

            // запрос у пользователя на просмотр сохранённых всех результатов тестов
            if (File.Exists(FileManager.ResultsFileName))
            {
                Console.WriteLine("Хотите посмотреть сохранённые результаты тестов? Введите \"Да\" или \"Нет\".");

                if (Apply(game.User))
                {
                    var testResults = FileManager.GetTestResults();
                    Console.WriteLine($"|| {"ФИО",-10} || {"кол-во правильных ответов",-25} || {"Диагноз",-10} ||");
                    foreach (var testResult in testResults) 
                    {
                        Console.WriteLine($"|| {testResult.Name,-10} || {testResult.RightAnswersCount,-25} || {testResult.Diagnose.Grade,-10} ||");
                    }
                }
            }

            // запрос у пользователя на добавление нового вопроса
            Console.WriteLine($"{game.User.Name}, желаете добавить свой вопрос? Введите \"Да\" или \"Нет\".");
            while (Apply(game.User))
            {
                Console.WriteLine("Введите вопрос и ответ на него в следующем формате: \"вопрос#ответ\". Без кавычек.\n" +
                    "Вопрос может состоять из цифр и чисел. Длина вопроса не менее 4 символов и не более 120.\n" +
                    "Ответ может быть только целочисленным.\n" +
                    "Использовать символ \"#\" не для разделения вопроса и ответа - запрещено.");

                var inputQuestion = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        inputQuestion.ValidateQuestion();
                        break;
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Строка не может быть пустой!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Ответ может быть только целочисленным. До 2000000000.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    inputQuestion = Console.ReadLine();
                }

                var questionSplit = inputQuestion.Split('#').Select(x => x.Trim()).ToArray();
                
                questionsStorage.AddQuestion(new Question(questionSplit[0], Convert.ToInt32(questionSplit[1])));
                

                FileManager.SaveQuestions(questionsStorage);
                Console.WriteLine("Вопрос успешно добавлен.");
                Console.WriteLine("Хотите добавить ещё вопрос? Введите \"Да\" или \"Нет\".");
            }

            // запрос у пользователя на удаление вопроса
            if (questionsStorage.Count > 0)
                Console.WriteLine($"{game.User.Name}, хотите удалить существующий вопрос? Введите \"Да\" или \"Нет\".");
            while (Apply(game.User))
            {
                if (questionsStorage.Count == 1)
                {
                    Console.WriteLine("Внимание, удаление последнего вопроса вернёт вопросы по умолчанию.");
                }
                Console.WriteLine("Введите номер вопроса, который хотите удалить. Список представлен ниже.");
                Console.WriteLine(game.QuestionsStorage);
                var questionNumber = Console.ReadLine();
                while (!Validation.ValidateQuestionNumber(questionNumber, questionsStorage))
                {
                    Console.WriteLine("Введите целочисленное число не меньше нуля и не больше количества вопросов!");
                    questionNumber = Console.ReadLine();
                }

                var number = int.Parse(questionNumber);
                var deletedQuestion = questionsStorage.Questions[number - 1];
                questionsStorage.RemoveQuestion(number);
                questionsStorage.SaveQuestions();
                Console.WriteLine("Вопрос:\n" +
                    $"\"{deletedQuestion}\"\n" +
                    "успешно удалён");

                if (questionsStorage.Count <= 0) 
                    break;

                Console.WriteLine("Хотите удалить ещё вопрос? Введите \"Да\" или \"Нет\".");
            }

            // запрос у пользователя на повтор теста
            Console.WriteLine("Хотите повторить тест? Введите \"Да\" или \"Нет\".");
            start = Apply(game.User);
        }
    }

    // спросить согласие пользователя
    static bool Apply(User user)
    {
        var userAnswer = Console.ReadLine().ToLower().ValidateUserAnswer();

        while (userAnswer == 0)
        {
            Console.WriteLine($"{user.Name}, вы ввели некорректные данные! Введите \"Да\" или \"Нет\".");
            userAnswer = Console.ReadLine().ToLower().ValidateUserAnswer();
        }

        return userAnswer == 1 ? true : false;
    }

    // получение имени у пользователя
    static string GetUserName()
    {
        Console.WriteLine("Здравствуйте, введите ваше имя! Длина имени не меньше двух символов. Можно использовать только латинский алфавит и цифры. Имя должно содержать хотя бы одну букву.");
        var userName = Console.ReadLine();
        while (!userName.ValidateUserName())
        {
            Console.WriteLine("Имя не соответствует требованиям! Попробуйте ввести другое имя.");
            userName = Console.ReadLine();
        }
        return userName;
    }

    // запуск теста
    static void StartTest(Game game)
    {
        game.Start();
        Console.WriteLine("Тест запущен. На каждый вопрос вводите целочисленный ответ. Примеры: \"2\", \"15\", \"-7\".");

        timer = new Timer(1000);
        timer.Elapsed += OnTimedEvent;

        var first = true;
        while (!game.IsEnd())
        {
            game.NextQuestion();
            Console.WriteLine(game.GetQuestionNumberText());
            Console.WriteLine("Введите ответ.");

            timer.Enabled = true;

            var input = Console.ReadLine();

            while (!game.AcceptAnswer(input) && timer.Enabled == true)
            {
                Console.WriteLine("Вы ввели некорректные данные! Введите целочисленное число в разумных пределах.\n" +
                    "Примеры: \"2\", \"15\", \"-7\".");
                input = Console.ReadLine();
            }
            
            if (timer.Enabled == true)
                Console.WriteLine($"Ответ \"{input}\" принят.");
                
            ticks = 10;
            
        }
        timer.Enabled = false;
        game.CalculateDiagnose();
    }

    static int ticks = 10;
    static Timer timer = null;

    private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        ticks--;
        Console.WriteLine($"Осталось секунд: {ticks}");
        if (ticks <= 0)
        {
            Console.WriteLine("Время истекло!");
            try
            {
                game.NextQuestion();
                Console.WriteLine("Следующий вопрос:");
                Console.WriteLine(game.GetQuestionNumberText());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Нажмите \"Enter\" чтобы продолжить.");
                timer.Enabled = false;
            }

            ticks = 10;
        }
    }
    
}