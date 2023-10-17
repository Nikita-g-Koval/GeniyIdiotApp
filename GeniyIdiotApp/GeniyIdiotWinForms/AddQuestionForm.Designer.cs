namespace GeniyIdiotWinForms
{
    partial class AddQuestionForm
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
            AddQuestionForm_Question_textBox = new System.Windows.Forms.TextBox();
            AddQuestionForm_Answer_textBox = new System.Windows.Forms.TextBox();
            AddQuestionForm_Add_button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            AddQuestionForm_Save_button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // AddQuestionForm_Question_textBox
            // 
            AddQuestionForm_Question_textBox.Location = new System.Drawing.Point(14, 33);
            AddQuestionForm_Question_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddQuestionForm_Question_textBox.Multiline = true;
            AddQuestionForm_Question_textBox.Name = "AddQuestionForm_Question_textBox";
            AddQuestionForm_Question_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            AddQuestionForm_Question_textBox.Size = new System.Drawing.Size(487, 117);
            AddQuestionForm_Question_textBox.TabIndex = 0;
            // 
            // AddQuestionForm_Answer_textBox
            // 
            AddQuestionForm_Answer_textBox.Location = new System.Drawing.Point(14, 180);
            AddQuestionForm_Answer_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddQuestionForm_Answer_textBox.Name = "AddQuestionForm_Answer_textBox";
            AddQuestionForm_Answer_textBox.Size = new System.Drawing.Size(229, 27);
            AddQuestionForm_Answer_textBox.TabIndex = 1;
            // 
            // AddQuestionForm_Add_button
            // 
            AddQuestionForm_Add_button.Location = new System.Drawing.Point(323, 180);
            AddQuestionForm_Add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddQuestionForm_Add_button.Name = "AddQuestionForm_Add_button";
            AddQuestionForm_Add_button.Size = new System.Drawing.Size(86, 31);
            AddQuestionForm_Add_button.TabIndex = 2;
            AddQuestionForm_Add_button.Text = "Добавить";
            AddQuestionForm_Add_button.UseVisualStyleBackColor = true;
            AddQuestionForm_Add_button.Click += AddQuestionForm_Add_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Вопрос";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 156);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Ответ";
            // 
            // AddQuestionForm_Save_button
            // 
            AddQuestionForm_Save_button.Location = new System.Drawing.Point(416, 179);
            AddQuestionForm_Save_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddQuestionForm_Save_button.Name = "AddQuestionForm_Save_button";
            AddQuestionForm_Save_button.Size = new System.Drawing.Size(86, 31);
            AddQuestionForm_Save_button.TabIndex = 14;
            AddQuestionForm_Save_button.Text = "Сохранить";
            AddQuestionForm_Save_button.UseVisualStyleBackColor = true;
            AddQuestionForm_Save_button.Click += AddQuestionForm_Save_button_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(515, 227);
            Controls.Add(AddQuestionForm_Save_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddQuestionForm_Add_button);
            Controls.Add(AddQuestionForm_Answer_textBox);
            Controls.Add(AddQuestionForm_Question_textBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AddQuestionForm";
            Text = "Добавить вопрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox AddQuestionForm_Question_textBox;
        private System.Windows.Forms.TextBox AddQuestionForm_Answer_textBox;
        private System.Windows.Forms.Button AddQuestionForm_Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddQuestionForm_Save_button;
    }
}