using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class RemoveQuestionForm : Form
    {
        Game game;
        QuestionsStorage questionsStorage;
        int questionNumber;

        public RemoveQuestionForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            questionsStorage = game.QuestionsStorage;
        }

        private void RemoveQuestionForm_Remove_button_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            if (questionsStorage.Count == 1)
            {
                result = MessageBox.Show("Остался последний вопрос! Если удалите его и начнёте тест, вопросы сбросятся по умолчанию.", "Предупреждение: Остался последний вопрос.", MessageBoxButtons.YesNo);
                if (!(result == DialogResult.Yes))
                {
                    return;
                }
            }

            questionsStorage.RemoveQuestion(questionNumber);
            MessageBox.Show("Вопрос успешно удалён.", "Успешно", buttons);
            ShowQuestions();
        }

        private void RemoveQuestionForm_Load(object sender, EventArgs e)
        {
            Questions_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Questions_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ShowQuestions();
        }

        private void RemoveQuestionForm_Save_button_Click(object sender, EventArgs e)
        {
            questionsStorage.SaveQuestions();
            MessageBox.Show("Вопросы успешно сохранены.", "Успешно", MessageBoxButtons.OK);
        }

        private void Questions_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (!Validation.ValidateQuestionNumber(index + 1, questionsStorage))
            {
                MessageBox.Show("Выберить строку с вопросом, который хотите удалить!", "Ошибка: Строка некорректна", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow selectedRow = Questions_dataGridView.Rows[index];
            questionNumber = Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void ShowQuestions()
        {
            Questions_dataGridView.Rows.Clear();

            var i = 1;
            foreach (var question in questionsStorage.Questions)
            {
                Questions_dataGridView.Rows.Add(i++, question.Text, question.Answer);
            }
        }
    }
}
