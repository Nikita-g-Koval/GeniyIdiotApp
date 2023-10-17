namespace GeniyIdiotWinForms
{
    partial class TestForm
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
            components = new System.ComponentModel.Container();
            TestForm_Main_textBox = new System.Windows.Forms.TextBox();
            TestForm_Answer_textBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            TestForm_Menu_button = new System.Windows.Forms.Button();
            TestForm_Start_button = new System.Windows.Forms.Button();
            TestForm_SaveResults_button = new System.Windows.Forms.Button();
            TestForm_Answer_timer = new System.Windows.Forms.Timer(components);
            TestForm_AnswerTimer_label = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // TestForm_Main_textBox
            // 
            TestForm_Main_textBox.Location = new System.Drawing.Point(12, 12);
            TestForm_Main_textBox.Multiline = true;
            TestForm_Main_textBox.Name = "TestForm_Main_textBox";
            TestForm_Main_textBox.ReadOnly = true;
            TestForm_Main_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            TestForm_Main_textBox.Size = new System.Drawing.Size(776, 163);
            TestForm_Main_textBox.TabIndex = 0;
            TestForm_Main_textBox.TabStop = false;
            TestForm_Main_textBox.TextChanged += TestForm_Main_textBox_TextChanged;
            // 
            // TestForm_Answer_textBox
            // 
            TestForm_Answer_textBox.Location = new System.Drawing.Point(10, 208);
            TestForm_Answer_textBox.Name = "TestForm_Answer_textBox";
            TestForm_Answer_textBox.Size = new System.Drawing.Size(180, 23);
            TestForm_Answer_textBox.TabIndex = 1;
            TestForm_Answer_textBox.KeyDown += TestForm_Answer_textBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 190);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Ответ";
            // 
            // TestForm_Menu_button
            // 
            TestForm_Menu_button.Location = new System.Drawing.Point(712, 208);
            TestForm_Menu_button.Name = "TestForm_Menu_button";
            TestForm_Menu_button.Size = new System.Drawing.Size(75, 23);
            TestForm_Menu_button.TabIndex = 3;
            TestForm_Menu_button.Text = "Меню";
            TestForm_Menu_button.UseVisualStyleBackColor = true;
            TestForm_Menu_button.Click += TestForm_Menu_button_Click;
            // 
            // TestForm_Start_button
            // 
            TestForm_Start_button.Location = new System.Drawing.Point(196, 208);
            TestForm_Start_button.Name = "TestForm_Start_button";
            TestForm_Start_button.Size = new System.Drawing.Size(172, 23);
            TestForm_Start_button.TabIndex = 4;
            TestForm_Start_button.Text = "Начать тест";
            TestForm_Start_button.UseVisualStyleBackColor = true;
            TestForm_Start_button.Click += TestForm_Start_button_Click;
            // 
            // TestForm_SaveResults_button
            // 
            TestForm_SaveResults_button.Location = new System.Drawing.Point(374, 208);
            TestForm_SaveResults_button.Name = "TestForm_SaveResults_button";
            TestForm_SaveResults_button.Size = new System.Drawing.Size(172, 23);
            TestForm_SaveResults_button.TabIndex = 8;
            TestForm_SaveResults_button.Text = "Сохранить результаты теста";
            TestForm_SaveResults_button.UseVisualStyleBackColor = true;
            TestForm_SaveResults_button.Click += TestForm_SaveResults_button_Click;
            // 
            // TestForm_Answer_timer
            // 
            TestForm_Answer_timer.Interval = 1000;
            TestForm_Answer_timer.Tick += TestForm_Answer_timer_Tick;
            // 
            // TestForm_AnswerTimer_label
            // 
            TestForm_AnswerTimer_label.AutoSize = true;
            TestForm_AnswerTimer_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TestForm_AnswerTimer_label.ForeColor = System.Drawing.Color.Gray;
            TestForm_AnswerTimer_label.Location = new System.Drawing.Point(552, 199);
            TestForm_AnswerTimer_label.Name = "TestForm_AnswerTimer_label";
            TestForm_AnswerTimer_label.Size = new System.Drawing.Size(89, 32);
            TestForm_AnswerTimer_label.TabIndex = 9;
            TestForm_AnswerTimer_label.Text = "Время:";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 236);
            Controls.Add(TestForm_AnswerTimer_label);
            Controls.Add(TestForm_SaveResults_button);
            Controls.Add(TestForm_Start_button);
            Controls.Add(TestForm_Menu_button);
            Controls.Add(label1);
            Controls.Add(TestForm_Answer_textBox);
            Controls.Add(TestForm_Main_textBox);
            Name = "TestForm";
            Text = "Тест";
            FormClosed += TestForm_FormClosed;
            Load += TestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TestForm_Main_textBox;
        private System.Windows.Forms.TextBox TestForm_Answer_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TestForm_Menu_button;
        private System.Windows.Forms.Button TestForm_Start_button;
        private System.Windows.Forms.Button TestForm_SaveResults_button;
        private System.Windows.Forms.Timer TestForm_Answer_timer;
        private System.Windows.Forms.Label TestForm_AnswerTimer_label;
    }
}