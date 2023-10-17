using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        public List<Question> Questions { get; set; }
        public int Count { get { return Questions.Count; } }

        public QuestionsStorage()
        {
            UpdateQuestions();
        }

        public QuestionsStorage(List<Question> questions)
        {
            Questions = questions;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void AddQuestions(IEnumerable<Question> questions)
        {
            Questions.AddRange(questions);
        }

        public void RemoveQuestion(int number)
        {
            Questions.RemoveAt(number - 1);
        }

        public void RemoveQuestions(int index, int count)
        {
            Questions.RemoveRange(index, count);
        }

        public void UpdateQuestions()
        {
            FileInfo fileInfo = new FileInfo(FileManager.QuestionsFileName);

            var questionsCount = 0;
            if (fileInfo.Exists)
            {
                Questions = FileManager.GetQuestions();
                questionsCount = Questions.Count;
            }
            
            if (questionsCount == 0 || !fileInfo.Exists)
            {
                Questions = new List<Question>()
                {
                    new Question("Сколько будет два плюс два умноженное на два?", 6),
                    new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                    new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                    new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                    new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
                };
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                (Questions[i], Questions[j]) = (Questions[j], Questions[i]);
            }
        }

        public List<Question> Shuffle(List<Question> questions)
        {
            Random random = new Random();
            for (int i = Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                (questions[i], questions[j]) = (questions[j], questions[i]);
            }
            return questions;
        }

        public override string ToString()
        {
            int i = 1;
            return string.Join('\n', Questions.Select(x =>
            {
                return $"№{i++}, вопрос: {x.Text}, ответ: {x.Answer}";
            }));
        }
    }
}


