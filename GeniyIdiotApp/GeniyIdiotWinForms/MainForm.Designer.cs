namespace GeniyIdiotWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_name = new System.Windows.Forms.Label();
            MainForm_Start_button = new System.Windows.Forms.Button();
            MainForm_Main_textBox = new System.Windows.Forms.TextBox();
            MainForm_Name_textBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new System.Drawing.Point(12, 152);
            label_name.Name = "label_name";
            label_name.Size = new System.Drawing.Size(34, 15);
            label_name.TabIndex = 2;
            label_name.Text = "Имя:";
            // 
            // MainForm_Start_button
            // 
            MainForm_Start_button.Location = new System.Drawing.Point(241, 136);
            MainForm_Start_button.Name = "MainForm_Start_button";
            MainForm_Start_button.Size = new System.Drawing.Size(126, 57);
            MainForm_Start_button.TabIndex = 3;
            MainForm_Start_button.Text = "Начать тест";
            MainForm_Start_button.UseVisualStyleBackColor = true;
            MainForm_Start_button.Click += MainForm_Start_button_Click;
            // 
            // MainForm_Main_textBox
            // 
            MainForm_Main_textBox.Location = new System.Drawing.Point(12, 12);
            MainForm_Main_textBox.Multiline = true;
            MainForm_Main_textBox.Name = "MainForm_Main_textBox";
            MainForm_Main_textBox.ReadOnly = true;
            MainForm_Main_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            MainForm_Main_textBox.Size = new System.Drawing.Size(355, 111);
            MainForm_Main_textBox.TabIndex = 5;
            MainForm_Main_textBox.TabStop = false;
            // 
            // MainForm_Name_textBox
            // 
            MainForm_Name_textBox.Location = new System.Drawing.Point(12, 170);
            MainForm_Name_textBox.Name = "MainForm_Name_textBox";
            MainForm_Name_textBox.Size = new System.Drawing.Size(198, 23);
            MainForm_Name_textBox.TabIndex = 13;
            MainForm_Name_textBox.KeyDown += MainForm_Name_textBox_KeyDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(382, 218);
            Controls.Add(MainForm_Name_textBox);
            Controls.Add(MainForm_Main_textBox);
            Controls.Add(MainForm_Start_button);
            Controls.Add(label_name);
            Name = "MainForm";
            Text = "GeniyIdiot";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button MainForm_Start_button;
        private System.Windows.Forms.TextBox MainForm_Main_textBox;
        private System.Windows.Forms.TextBox MainForm_Name_textBox;
    }
}
