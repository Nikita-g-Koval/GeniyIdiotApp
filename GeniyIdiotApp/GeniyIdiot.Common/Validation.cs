using System;
using System.Linq;


namespace GeniyIdiot.Common
{
    public static class Validation
    {
        // проверка строки на целочисленное число
        public static bool IsInteger(this string input)
        {
            int temp;

            return int.TryParse(input, out temp);
        }

        // проверка имени пользователя
        public static bool ValidateUserName(this string userName)
        {
            if (userName.Any(x => !char.IsLetterOrDigit(x)) || !userName.Any(char.IsLetter) || userName.Length < 2)
                return false;
            return true;
        }

        // проверить ответ пользователя, возвращает 1, если ответ - "да"; -1 - "нет"; 0 - ни "да", ни "нет"
        public static int ValidateUserAnswer(this string userAnswer)
        {
            if (userAnswer != "да" && userAnswer != "нет")
                return 0;

            return userAnswer == "да" ? 1 : -1;
        }

        /// <summary>
        /// проверяет новый вопрос и ответ, выбрасывает соответствующее исключение при нарушении корректности
        /// </summary>
        /// <param name="question"></param>
        /// <returns>false, если ответ строковый; true, если целочисленный</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidateQuestion(this string question)
        {
            if (string.IsNullOrEmpty(question))
                throw new ArgumentNullException(nameof(question));

            var separatorCount = question.Count(c => c == '#');
            if (separatorCount > 1 || separatorCount < 1)
                throw new Exception("Использовать символ \"#\" не для разделения вопроса и ответа - запрещено. Необходимо присутствие одного символа \"#\"");

            var splitQuestion = question.Split('#');
            var text = splitQuestion[0];
            var answer = splitQuestion[1];

            var textLength = text.Length;
            if (textLength < 4 || textLength > 120)
                throw new Exception("Длина вопроса не менее 4 символов и не более 120.");

            if (!answer.IsInteger())
                throw new ArgumentException();
        }

        public static void ValidateQuestion(string question, string answer)
        {
            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
                throw new ArgumentNullException();

            var textLength = question.Length;
            if (textLength < 4 || textLength > 120)
                throw new Exception("Длина вопроса не менее 4 символов и не более 120.");

            if (!answer.IsInteger())
                throw new ArgumentException();
        }

        public static bool ValidateQuestionNumber(int questionNumber, QuestionsStorage questionsStorage)
        { 
            var number = questionNumber;
            if (number < 1 || number > questionsStorage.Count)
                return false;

            return true;
        }

        public static bool ValidateQuestionNumber(string questionNumber, QuestionsStorage questionsStorage)
        {
            if (!questionNumber.IsInteger())
                return false;

            var number = int.Parse(questionNumber);
            if (number < 1 || number > questionsStorage.Count)
                return false;

            return true;
        }
    }
}

