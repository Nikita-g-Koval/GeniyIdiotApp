using GeniyIdiot.Common;
using System;
using System.IO;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class ResultsForm : Form
    {
        Game game;

        public ResultsForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void ResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ResultsForm_ShowResults_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileManager.ResultsFileName))
            {
                var testResults = FileManager.GetTestResults();

                Results_DataGridView.Rows.Clear();
                foreach (var testResult in testResults)
                {
                    Results_DataGridView.Rows.Add(testResult.Name, testResult.RightAnswersCount, testResult.Diagnose.Grade);
                }
            }
        }

        private void ResultsForm_ClearResults_button_Click(object sender, EventArgs e)
        {
            {
                FileManager.ClearTestResults();
                Results_DataGridView.Rows.Clear();
                MessageBox.Show("Результаты тестов удалены.", "Успешно", MessageBoxButtons.OK);
            }
        }

    }
}
