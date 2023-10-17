using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiot.Common
{
    public class DiagnosesStorage
    {
        public List<Diagnosis> Diagnoses { get; }
        public int Count { get { return Diagnoses.Count; } }

        public DiagnosesStorage()
        {
            Diagnoses = new List<Diagnosis>()
            {
                new Diagnosis("Кретин"),
                new Diagnosis("Идиот"),
                new Diagnosis("Дурак"),
                new Diagnosis("Нормальный"),
                new Diagnosis("Талант"),
                new Diagnosis("Гений")
            };
        }

        public Diagnosis GetDiagnose(int questionsCount, int rightAnswersCount)
        {
            int rightAnswersPercentage = rightAnswersCount * 100 / questionsCount;
            Diagnosis result = Diagnoses[0];

            switch (rightAnswersPercentage)
            {
                case > 0 and <= 20:
                    result = Diagnoses[1];
                    break;
                case > 20 and <= 40:
                    result = Diagnoses[2];
                    break;
                case > 40 and <= 60:
                    result = Diagnoses[3];
                    break;
                case > 60 and <= 80:
                    result = Diagnoses[4];
                    break;
                case > 80:
                    result = Diagnoses[5];
                    break;
            }

            return result;
        }

        public override string ToString()
        {
            int i = 1;
            return string.Join('\n', Diagnoses.Select(x =>
            {
                return $"№{i++}, {x.Grade}";
            }));
        }
    }
}

