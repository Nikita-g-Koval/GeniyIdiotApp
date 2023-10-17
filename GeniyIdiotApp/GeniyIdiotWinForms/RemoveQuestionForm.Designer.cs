namespace GeniyIdiotWinForms
{
    partial class RemoveQuestionForm
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
            RemoveQuestionForm_Remove_button = new System.Windows.Forms.Button();
            Info_label = new System.Windows.Forms.Label();
            RemoveQuestionForm_Save_button = new System.Windows.Forms.Button();
            Questions_dataGridView = new System.Windows.Forms.DataGridView();
            QuestionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Questions_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // RemoveQuestionForm_Remove_button
            // 
            RemoveQuestionForm_Remove_button.Location = new System.Drawing.Point(420, 13);
            RemoveQuestionForm_Remove_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RemoveQuestionForm_Remove_button.Name = "RemoveQuestionForm_Remove_button";
            RemoveQuestionForm_Remove_button.Size = new System.Drawing.Size(92, 31);
            RemoveQuestionForm_Remove_button.TabIndex = 1;
            RemoveQuestionForm_Remove_button.Text = "Удалить";
            RemoveQuestionForm_Remove_button.UseVisualStyleBackColor = true;
            RemoveQuestionForm_Remove_button.Click += RemoveQuestionForm_Remove_button_Click;
            // 
            // Info_label
            // 
            Info_label.AutoSize = true;
            Info_label.Location = new System.Drawing.Point(12, 13);
            Info_label.Name = "Info_label";
            Info_label.Size = new System.Drawing.Size(307, 20);
            Info_label.TabIndex = 2;
            Info_label.Text = "Выберить вопрос, который хотите удалить";
            // 
            // RemoveQuestionForm_Save_button
            // 
            RemoveQuestionForm_Save_button.Location = new System.Drawing.Point(518, 13);
            RemoveQuestionForm_Save_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RemoveQuestionForm_Save_button.Name = "RemoveQuestionForm_Save_button";
            RemoveQuestionForm_Save_button.Size = new System.Drawing.Size(92, 31);
            RemoveQuestionForm_Save_button.TabIndex = 15;
            RemoveQuestionForm_Save_button.Text = "Сохранить";
            RemoveQuestionForm_Save_button.UseVisualStyleBackColor = true;
            RemoveQuestionForm_Save_button.Click += RemoveQuestionForm_Save_button_Click;
            // 
            // Questions_dataGridView
            // 
            Questions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Questions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { QuestionNumber, QuestionText, Answer });
            Questions_dataGridView.Location = new System.Drawing.Point(12, 51);
            Questions_dataGridView.Name = "Questions_dataGridView";
            Questions_dataGridView.RowHeadersWidth = 51;
            Questions_dataGridView.RowTemplate.Height = 29;
            Questions_dataGridView.Size = new System.Drawing.Size(594, 278);
            Questions_dataGridView.TabIndex = 16;
            Questions_dataGridView.CellClick += Questions_dataGridView_CellClick;
            // 
            // QuestionNumber
            // 
            QuestionNumber.HeaderText = "Номер вопроса";
            QuestionNumber.MinimumWidth = 6;
            QuestionNumber.Name = "QuestionNumber";
            QuestionNumber.ReadOnly = true;
            QuestionNumber.Width = 75;
            // 
            // QuestionText
            // 
            QuestionText.HeaderText = "Текст вопроса";
            QuestionText.MinimumWidth = 6;
            QuestionText.Name = "QuestionText";
            QuestionText.ReadOnly = true;
            QuestionText.Width = 350;
            // 
            // Answer
            // 
            Answer.HeaderText = "Ответ на вопрос";
            Answer.MinimumWidth = 6;
            Answer.Name = "Answer";
            Answer.ReadOnly = true;
            Answer.Width = 115;
            // 
            // RemoveQuestionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(622, 341);
            Controls.Add(Questions_dataGridView);
            Controls.Add(RemoveQuestionForm_Save_button);
            Controls.Add(Info_label);
            Controls.Add(RemoveQuestionForm_Remove_button);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "RemoveQuestionForm";
            Text = "Удалить вопрос";
            Load += RemoveQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)Questions_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button RemoveQuestionForm_Remove_button;
        private System.Windows.Forms.Label Info_label;
        private System.Windows.Forms.Button RemoveQuestionForm_Save_button;
        private System.Windows.Forms.DataGridView Questions_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}