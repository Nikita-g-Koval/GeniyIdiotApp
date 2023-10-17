using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class MenuForm : Form
    {
        Game game;

        public MenuForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void MenuForm_AddQuestion_button_Click(object sender, EventArgs e)
        {
            AddQuestionForm form = new AddQuestionForm(game);
            form.ShowDialog();
        }

        private void MenuForm_RemoveQuestion_button_Click(object sender, EventArgs e)
        {
            RemoveQuestionForm form = new RemoveQuestionForm(game);
            form.ShowDialog();
        }

        private void MenuForm_StartTest_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Точно хотите начать тест?", "Начать тест", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TestForm form = new TestForm(game);
                Hide();
                form.ShowDialog();
                Close();
            }
        }

        private void MenuForm_Results_button_Click(object sender, EventArgs e)
        {
            ResultsForm form = new ResultsForm(game);
            form.ShowDialog();
        }

        private void MenuForm_UndoChanges_button_Click(object sender, EventArgs e)
        {
            FileManager.ClearQuestions();
            game.QuestionsStorage.UpdateQuestions();
            DialogResult result = MessageBox.Show("Вопросы по умолчанию", "Успешно", MessageBoxButtons.OK);
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
