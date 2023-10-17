namespace GeniyIdiotWinForms
{
    partial class ResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResultsForm_ShowResults_button = new System.Windows.Forms.Button();
            ResultsForm_ClearResults_button = new System.Windows.Forms.Button();
            Results_DataGridView = new System.Windows.Forms.DataGridView();
            UserNameColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RightAnswersCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Results_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // ResultsForm_ShowResults_button
            // 
            ResultsForm_ShowResults_button.Location = new System.Drawing.Point(14, 277);
            ResultsForm_ShowResults_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ResultsForm_ShowResults_button.Name = "ResultsForm_ShowResults_button";
            ResultsForm_ShowResults_button.Size = new System.Drawing.Size(226, 31);
            ResultsForm_ShowResults_button.TabIndex = 8;
            ResultsForm_ShowResults_button.Text = "Посмотреть результаты тестов";
            ResultsForm_ShowResults_button.UseVisualStyleBackColor = true;
            ResultsForm_ShowResults_button.Click += ResultsForm_ShowResults_button_Click;
            // 
            // ResultsForm_ClearResults_button
            // 
            ResultsForm_ClearResults_button.Location = new System.Drawing.Point(14, 316);
            ResultsForm_ClearResults_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ResultsForm_ClearResults_button.Name = "ResultsForm_ClearResults_button";
            ResultsForm_ClearResults_button.Size = new System.Drawing.Size(226, 31);
            ResultsForm_ClearResults_button.TabIndex = 13;
            ResultsForm_ClearResults_button.Text = "Очистить результаты тестов";
            ResultsForm_ClearResults_button.UseVisualStyleBackColor = true;
            ResultsForm_ClearResults_button.Click += ResultsForm_ClearResults_button_Click;
            // 
            // Results_DataGridView
            // 
            Results_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Results_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { UserNameColomn, RightAnswersCountColumn, DiagnosisColumn });
            Results_DataGridView.Location = new System.Drawing.Point(14, 16);
            Results_DataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Results_DataGridView.Name = "Results_DataGridView";
            Results_DataGridView.RowHeadersWidth = 51;
            Results_DataGridView.RowTemplate.Height = 25;
            Results_DataGridView.Size = new System.Drawing.Size(384, 253);
            Results_DataGridView.TabIndex = 15;
            // 
            // UserNameColomn
            // 
            UserNameColomn.HeaderText = "Имя";
            UserNameColomn.MinimumWidth = 6;
            UserNameColomn.Name = "UserNameColomn";
            UserNameColomn.ReadOnly = true;
            UserNameColomn.Width = 125;
            // 
            // RightAnswersCountColumn
            // 
            RightAnswersCountColumn.HeaderText = "Кол-во правильных ответов";
            RightAnswersCountColumn.MinimumWidth = 6;
            RightAnswersCountColumn.Name = "RightAnswersCountColumn";
            RightAnswersCountColumn.ReadOnly = true;
            RightAnswersCountColumn.Width = 125;
            // 
            // DiagnosisColumn
            // 
            DiagnosisColumn.HeaderText = "Диагноз";
            DiagnosisColumn.MinimumWidth = 6;
            DiagnosisColumn.Name = "DiagnosisColumn";
            DiagnosisColumn.ReadOnly = true;
            DiagnosisColumn.Width = 125;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(413, 359);
            Controls.Add(Results_DataGridView);
            Controls.Add(ResultsForm_ClearResults_button);
            Controls.Add(ResultsForm_ShowResults_button);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ResultsForm";
            Text = "ResultsForm";
            FormClosed += ResultsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Results_DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button ResultsForm_ShowResults_button;
        private System.Windows.Forms.Button ResultsForm_ClearResults_button;
        private System.Windows.Forms.DataGridView Results_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightAnswersCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisColumn;
    }
}