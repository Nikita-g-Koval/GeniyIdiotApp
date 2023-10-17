namespace GeniyIdiot.Common
{
    public class Question
    {
        public string Text { get; }
        public int Answer { get; }

        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }

        public override string ToString()
        {
            return $"{Text}, {Answer}";
        }
    }
}

