namespace GeniyIdiotWinForms
{
    partial class MenuForm
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
            MenuForm_AddQuestion_button = new System.Windows.Forms.Button();
            MenuForm_RemoveQuestion_button = new System.Windows.Forms.Button();
            MenuForm_Results_button = new System.Windows.Forms.Button();
            MenuForm_StartTest_button = new System.Windows.Forms.Button();
            MenuForm_UndoChanges_button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // MenuForm_AddQuestion_button
            // 
            MenuForm_AddQuestion_button.Location = new System.Drawing.Point(15, 93);
            MenuForm_AddQuestion_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuForm_AddQuestion_button.Name = "MenuForm_AddQuestion_button";
            MenuForm_AddQuestion_button.Size = new System.Drawing.Size(226, 31);
            MenuForm_AddQuestion_button.TabIndex = 9;
            MenuForm_AddQuestion_button.Text = "Добавить вопрос";
            MenuForm_AddQuestion_button.UseVisualStyleBackColor = true;
            MenuForm_AddQuestion_button.Click += MenuForm_AddQuestion_button_Click;
            // 
            // MenuForm_RemoveQuestion_button
            // 
            MenuForm_RemoveQuestion_button.Location = new System.Drawing.Point(15, 132);
            MenuForm_RemoveQuestion_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuForm_RemoveQuestion_button.Name = "MenuForm_RemoveQuestion_button";
            MenuForm_RemoveQuestion_button.Size = new System.Drawing.Size(226, 31);
            MenuForm_RemoveQuestion_button.TabIndex = 10;
            MenuForm_RemoveQuestion_button.Text = "Удалить вопрос";
            MenuForm_RemoveQuestion_button.UseVisualStyleBackColor = true;
            MenuForm_RemoveQuestion_button.Click += MenuForm_RemoveQuestion_button_Click;
            // 
            // MenuForm_Results_button
            // 
            MenuForm_Results_button.Location = new System.Drawing.Point(15, 55);
            MenuForm_Results_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuForm_Results_button.Name = "MenuForm_Results_button";
            MenuForm_Results_button.Size = new System.Drawing.Size(226, 31);
            MenuForm_Results_button.TabIndex = 11;
            MenuForm_Results_button.Text = "Результаты";
            MenuForm_Results_button.UseVisualStyleBackColor = true;
            MenuForm_Results_button.Click += MenuForm_Results_button_Click;
            // 
            // MenuForm_StartTest_button
            // 
            MenuForm_StartTest_button.Location = new System.Drawing.Point(15, 16);
            MenuForm_StartTest_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuForm_StartTest_button.Name = "MenuForm_StartTest_button";
            MenuForm_StartTest_button.Size = new System.Drawing.Size(226, 31);
            MenuForm_StartTest_button.TabIndex = 12;
            MenuForm_StartTest_button.Text = "Тест";
            MenuForm_StartTest_button.UseVisualStyleBackColor = true;
            MenuForm_StartTest_button.Click += MenuForm_StartTest_button_Click;
            // 
            // MenuForm_UndoChanges_button
            // 
            MenuForm_UndoChanges_button.BackColor = System.Drawing.Color.Red;
            MenuForm_UndoChanges_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MenuForm_UndoChanges_button.Location = new System.Drawing.Point(15, 211);
            MenuForm_UndoChanges_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MenuForm_UndoChanges_button.Name = "MenuForm_UndoChanges_button";
            MenuForm_UndoChanges_button.Size = new System.Drawing.Size(226, 31);
            MenuForm_UndoChanges_button.TabIndex = 14;
            MenuForm_UndoChanges_button.Text = "Отменить изменения";
            MenuForm_UndoChanges_button.UseVisualStyleBackColor = false;
            MenuForm_UndoChanges_button.Click += MenuForm_UndoChanges_button_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(255, 257);
            Controls.Add(MenuForm_UndoChanges_button);
            Controls.Add(MenuForm_StartTest_button);
            Controls.Add(MenuForm_Results_button);
            Controls.Add(MenuForm_RemoveQuestion_button);
            Controls.Add(MenuForm_AddQuestion_button);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "Menu";
            FormClosed += MenuForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button MenuForm_AddQuestion_button;
        private System.Windows.Forms.Button MenuForm_RemoveQuestion_button;
        private System.Windows.Forms.Button MenuForm_Results_button;
        private System.Windows.Forms.Button MenuForm_StartTest_button;
        private System.Windows.Forms.Button MenuForm_UndoChanges_button;
    }
}