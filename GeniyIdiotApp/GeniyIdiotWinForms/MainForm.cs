using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{

    public partial class MainForm : Form
    {
        Game game;

        string inputName;
        bool start = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Main_textBox.Text = "Здравствуйте, введите ваше имя в поле \"Ответ\" и нажмите клавишу \"Enter\"! Длина имени не меньше двух символов. " +
                "Можно использовать только буквы и цифры. Имя должно содержать хотя бы одну букву.";
        }

        private void MainForm_Start_button_Click(object sender, EventArgs e)
        {
            if (start)
            {
                TestForm form = new TestForm(game);
                Hide();
                form.ShowDialog();
            }
            else
            {
                inputName = MainForm_Name_textBox.Text;

                if (!inputName.ValidateUserName())
                    MainForm_Main_textBox.Text = "Имя не соответствует требованиям! Попробуйте ввести другое имя.";
                else
                {
                    game = new Game(new User(inputName), new QuestionsStorage(), new DiagnosesStorage());
                    start = true;
                    TestForm form = new TestForm(game);
                    Hide();
                    form.ShowDialog();
                }
            }
        }

        private void MainForm_Name_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputName = MainForm_Name_textBox.Text;
                MainForm_Name_textBox.Text = string.Empty;
                e.SuppressKeyPress = true;

                if (!inputName.ValidateUserName())
                    MainForm_Main_textBox.Text = "Имя не соответствует требованиям! Попробуйте ввести другое имя.";
                else
                {
                    game = new Game(new User(inputName), new QuestionsStorage(), new DiagnosesStorage());
                    MainForm_Name_textBox.Text = inputName;
                    MainForm_Name_textBox.Enabled = false;
                    start = true;
                    MainForm_Main_textBox.Text = $"{game.User.Name}, теперь можете начать тест.";
                }
            }
        }
    }
}
