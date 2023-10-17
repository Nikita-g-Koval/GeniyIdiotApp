using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiot.Common
{
    public class Game
    {
        public User User { get; }
        public QuestionsStorage QuestionsStorage { get; }
        DiagnosesStorage diagnosesStorage = new DiagnosesStorage();
        Question currentQuestion;
        int currentQuestionId = 0;
        int nextQuestionId = 0;
        
        public Game(User user, QuestionsStorage questionsStorage, DiagnosesStorage diagnosesStorage)
        {
            User = user;
            QuestionsStorage = new QuestionsStorage();
            QuestionsStorage.Shuffle();
        }

        // перейти на следующий вопрос
        public void NextQuestion()
        {
            if (IsEnd())
            {
                throw new Exception("Игра закончилась! Вопросов больше нет!");
            }

            currentQuestionId = nextQuestionId;
            currentQuestion = QuestionsStorage.Questions[currentQuestionId];
            nextQuestionId++;
        }

        public string GetQuestionNumberText()
        {
            return $"Вопрос №{currentQuestionId + 1}. {currentQuestion.Text}";
        }

        public bool AcceptAnswer(string answer)
        {
            if (!answer.IsInteger())
            {
                return false;
            }
            else
            {
                var intAnswer = int.Parse(answer);

                if (intAnswer == currentQuestion.Answer)
                {
                    User.RightAnswersCount++;
                }
            }

            return true;
        }

        public void CalculateDiagnose()
        {
            if (!IsEnd())
            {
                throw new Exception("Игра ещё не закончилась! Сначала завершите игру.");
            }

            User.Diagnose = diagnosesStorage.GetDiagnose(QuestionsStorage.Count, User.RightAnswersCount);
        }

        public bool IsEnd()
        {
            return nextQuestionId >= QuestionsStorage.Count;
        }

        public void Start()
        {
            QuestionsStorage.UpdateQuestions();
            User.RightAnswersCount = 0;
            currentQuestionId = 0;
            nextQuestionId = 0;
            QuestionsStorage.Shuffle();
        }
    }
}
