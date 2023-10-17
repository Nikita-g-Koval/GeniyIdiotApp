using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiot.Common
{
    public static class FileManager
    {
        public const string ResultsFileName = "testResults.json";
        public const string QuestionsFileName = "questions.json";

        // сохранение результатов текста в файл
        public static void SaveTestResult(this User user)
        {
            FileInfo fileInfo = new FileInfo(ResultsFileName);

            List<User> users = new List<User>();
            
            if (fileInfo.Exists)
            {
                users = GetTestResults();
            }

            users.Add(user);

            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);

            using (var sw = new StreamWriter(ResultsFileName, false, Encoding.UTF8))
            {
                sw.WriteLine(jsonData);
            }
        }

        // возвращает содержимое файла с результатами теста, если файла не существует возвращает null
        public static List<User> GetTestResults()
        {
            if (File.Exists(ResultsFileName))
            {
                using (var sr = new StreamReader(ResultsFileName, Encoding.UTF8))
                {
                    var fileData = sr.ReadToEnd();
                    var testResults = JsonConvert.DeserializeObject<List<User>>(fileData);
                    return testResults;
                }
            }
            return null;
        }

        // удалить файл с результатами тестов
        public static bool ClearTestResults()
        {
            FileInfo fileInfo = new FileInfo(ResultsFileName);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
                return true;
            }
            
            return false;
        }

        // сохраняет вопросы в файл
        public static void SaveQuestions(this QuestionsStorage questionsStorage)
        {
            FileInfo fileInfo = new FileInfo(QuestionsFileName);
            var jsonData = JsonConvert.SerializeObject(questionsStorage.Questions, Formatting.Indented);

            using (var sw = fileInfo.CreateText())
            {
                sw.WriteLine(jsonData);
            }
        }

        // возвращает содержимое файла с вопросами, если файла не существует возвращает null
        public static List<Question> GetQuestions()
        {
            var result = new List<Question>();
            if (File.Exists(QuestionsFileName))
            {
                using (var sr = new StreamReader(QuestionsFileName, Encoding.UTF8))
                {
                    var jsonData = sr.ReadToEnd();
                    result = JsonConvert.DeserializeObject<List<Question>>(jsonData);
                }
            }
            else
                return null;

            return result;
        }

        // удалить файл qustions.txt
        public static bool ClearQuestions()
        {
            FileInfo fileInfo = new FileInfo(QuestionsFileName);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
                return true;
            }

            return false;
        }
    }
}

