using GeniyIdiot.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class TestForm : Form
    {
        Game game;

        int ticks;

        string input;
        bool testFinished = false;

        public TestForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void TestForm_Answer_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input = TestForm_Answer_textBox.Text;
                TestForm_Answer_textBox.Text = string.Empty;
                e.SuppressKeyPress = true;

                if (!game.AcceptAnswer(input))
                {
                    TestForm_Main_textBox.Text += "Вы ввели некорректные данные! Введите целочисленное число в разумных пределах!" + 
                        Environment.NewLine;
                }
                else
                {
                    TestForm_Main_textBox.Text = $"Ответ \"{input}\" принят." + Environment.NewLine;
                    if (game.IsEnd())
                    {
                        game.CalculateDiagnose();
                        testFinished = true;
                        TestForm_Answer_timer.Stop();
                        TestForm_AnswerTimer_label.ForeColor = Color.Gray;
                        TestForm_Main_textBox.Text = $"Тест завершён. Количество правильных ответов: {game.User.RightAnswersCount}" + Environment.NewLine +
                            $"{game.User.Name}, ваш диагноз {game.User.Diagnose.Grade}";
                        TestForm_Answer_textBox.Enabled = false;
                    }
                    else
                    {
                        ticks = 10;
                        game.NextQuestion();
                        TestForm_Main_textBox.Text += $"{game.GetQuestionNumberText()}" + Environment.NewLine +
                            "Введите ответ на вопрос." + Environment.NewLine;
                    }
                }
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            TestForm_Main_textBox.Text = $"Время ответа на каждый вопрос 10 секунд. На каждый вопрос вводите целочисленный ответ в поле \"Ответ\". Примеры: \"2\", \"15\", \"-7\"." + Environment.NewLine;
            TestForm_Answer_textBox.Enabled = false;
        }

        private void TestForm_Start_button_Click(object sender, EventArgs e)
        {
            ticks = 10;
            game.Start();
            game.NextQuestion();
            TestForm_Main_textBox.Text = $"{game.User.Name}, тест запущен. На каждый вопрос вводите целочисленный ответ в поле \"Ответ\". Примеры: \"2\", \"15\", \"-7\"." + Environment.NewLine;
            TestForm_Main_textBox.Text += $"{game.GetQuestionNumberText()}" + Environment.NewLine +
                "Введите ответ на вопрос." + Environment.NewLine;
            TestForm_Answer_textBox.Enabled = true;

            TestForm_Answer_timer.Start();
            TestForm_AnswerTimer_label.ForeColor = Color.Red;
        }

        private void TestForm_Menu_button_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm(game);
            Hide();
            form.ShowDialog();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TestForm_Main_textBox_TextChanged(object sender, EventArgs e)
        {
            TestForm_Main_textBox.SelectionStart = TestForm_Main_textBox.Text.Length;
            TestForm_Main_textBox.ScrollToCaret();
        }

        private void TestForm_SaveResults_button_Click(object sender, EventArgs e)
        {
            if (testFinished)
            {
                game.User.SaveTestResult();
                TestForm_Main_textBox.Text = "Результаты теста успешно сохранены.";
            }
            else
                TestForm_Main_textBox.Text = "Для начала пройдите тест!";
        }

        private void TestForm_Answer_timer_Tick(object sender, EventArgs e)
        {
            ticks--;
            TestForm_AnswerTimer_label.Text = $"Время: {ticks}";

            if (ticks <= 0)
            {
                ticks = 10;
                if (game.IsEnd())
                {
                    game.CalculateDiagnose();
                    testFinished = true;
                    TestForm_Answer_timer.Stop();
                    TestForm_AnswerTimer_label.ForeColor = Color.Gray;
                    TestForm_Main_textBox.Text = $"Тест завершён. Количество правильных ответов: {game.User.RightAnswersCount}" + Environment.NewLine +
                            $"{game.User.Name}, ваш диагноз {game.User.Diagnose.Grade}";
                }
                else
                {
                    TestForm_Main_textBox.Text = "Вы не успели ответить на вопрос. Следующий вопрос:" + Environment.NewLine;
                    game.NextQuestion();
                    TestForm_Main_textBox.Text += $"{game.GetQuestionNumberText()}" + Environment.NewLine +
                                "Введите ответ на вопрос." + Environment.NewLine;
                }
            }
        }
    }
}
