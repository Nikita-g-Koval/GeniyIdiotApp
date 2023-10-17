namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; set; }
        public Diagnosis Diagnose { get; set; }
        public int RightAnswersCount { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}

