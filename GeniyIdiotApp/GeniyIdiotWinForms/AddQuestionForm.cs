using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class AddQuestionForm : Form
    {
        Game game;
        QuestionsStorage questionsStorage;

        public AddQuestionForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            questionsStorage = game.QuestionsStorage;
        }

        private void AddQuestionForm_Add_button_Click(object sender, EventArgs e)
        {
            var questionText = AddQuestionForm_Question_textBox.Text;
            var answer = AddQuestionForm_Answer_textBox.Text;

            var caption = "Ошибка ввода данных";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            try
            {
                Validation.ValidateQuestion(questionText, answer);
                questionsStorage.AddQuestion(new Question(questionText, int.Parse(answer)));
                MessageBox.Show("Вопрос успешно добавлен.", "Успешно", buttons);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Вопрос или ответ не могут быть пустыми!", caption, buttons);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ответ может быть только целочисленным в разумных пределах.", caption, buttons);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, caption, buttons);
            }
        }

        private void AddQuestionForm_Save_button_Click(object sender, EventArgs e)
        {
            questionsStorage.SaveQuestions();
            MessageBox.Show("Вопросы успешно сохранены.", "Успешно", MessageBoxButtons.OK);
        }
    }
}
