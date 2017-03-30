namespace ExcTractor
{
    partial class Form_Main
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
            this.listBox_ConfigList = new System.Windows.Forms.ListBox();
            this.button_NewConfig = new System.Windows.Forms.Button();
            this.button_DeleteConfig = new System.Windows.Forms.Button();
            this.button_RenameConfig = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Config_Excel = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Browse_Excel = new System.Windows.Forms.Button();
            this.button_Save_Excel = new System.Windows.Forms.Button();
            this.button_SheetFilters_Excel = new System.Windows.Forms.Button();
            this.radioButton_ModifiedOnly_Excel = new System.Windows.Forms.RadioButton();
            this.textBox_Period_Excel = new System.Windows.Forms.TextBox();
            this.textBox_File_Excel = new System.Windows.Forms.TextBox();
            this.textBox_Password_Excel = new System.Windows.Forms.TextBox();
            this.textBox_User_Excel = new System.Windows.Forms.TextBox();
            this.textBox_Host_Excel = new System.Windows.Forms.TextBox();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Config_Excel.SuspendLayout();
            this.tabPage_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_ConfigList
            // 
            this.listBox_ConfigList.FormattingEnabled = true;
            this.listBox_ConfigList.Location = new System.Drawing.Point(15, 13);
            this.listBox_ConfigList.Name = "listBox_ConfigList";
            this.listBox_ConfigList.Size = new System.Drawing.Size(146, 342);
            this.listBox_ConfigList.TabIndex = 0;
            // 
            // button_NewConfig
            // 
            this.button_NewConfig.Location = new System.Drawing.Point(16, 365);
            this.button_NewConfig.Name = "button_NewConfig";
            this.button_NewConfig.Size = new System.Drawing.Size(145, 23);
            this.button_NewConfig.TabIndex = 1;
            this.button_NewConfig.Text = "New Config";
            this.button_NewConfig.UseVisualStyleBackColor = true;
            this.button_NewConfig.Click += new System.EventHandler(this.button_NewConfig_Click);
            // 
            // button_DeleteConfig
            // 
            this.button_DeleteConfig.Location = new System.Drawing.Point(16, 398);
            this.button_DeleteConfig.Name = "button_DeleteConfig";
            this.button_DeleteConfig.Size = new System.Drawing.Size(145, 23);
            this.button_DeleteConfig.TabIndex = 1;
            this.button_DeleteConfig.Text = "Delete Config";
            this.button_DeleteConfig.UseVisualStyleBackColor = true;
            this.button_DeleteConfig.Click += new System.EventHandler(this.button_DeleteConfig_Click);
            // 
            // button_RenameConfig
            // 
            this.button_RenameConfig.Location = new System.Drawing.Point(16, 428);
            this.button_RenameConfig.Name = "button_RenameConfig";
            this.button_RenameConfig.Size = new System.Drawing.Size(145, 23);
            this.button_RenameConfig.TabIndex = 1;
            this.button_RenameConfig.Text = "Rename Config";
            this.button_RenameConfig.UseVisualStyleBackColor = true;
            this.button_RenameConfig.Click += new System.EventHandler(this.button_RenameConfig_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Config_Excel);
            this.tabControl1.Controls.Add(this.tabPage_Log);
            this.tabControl1.Location = new System.Drawing.Point(178, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 442);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_Config_Excel
            // 
            this.tabPage_Config_Excel.Controls.Add(this.label5);
            this.tabPage_Config_Excel.Controls.Add(this.label4);
            this.tabPage_Config_Excel.Controls.Add(this.label3);
            this.tabPage_Config_Excel.Controls.Add(this.label2);
            this.tabPage_Config_Excel.Controls.Add(this.label1);
            this.tabPage_Config_Excel.Controls.Add(this.button_Browse_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.button_Save_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.button_SheetFilters_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.radioButton_ModifiedOnly_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_Period_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_File_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_Password_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_User_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_Host_Excel);
            this.tabPage_Config_Excel.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Config_Excel.Name = "tabPage_Config_Excel";
            this.tabPage_Config_Excel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Config_Excel.Size = new System.Drawing.Size(670, 416);
            this.tabPage_Config_Excel.TabIndex = 0;
            this.tabPage_Config_Excel.Text = "Config";
            this.tabPage_Config_Excel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Extraction Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Host IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // button_Browse_Excel
            // 
            this.button_Browse_Excel.Enabled = false;
            this.button_Browse_Excel.Location = new System.Drawing.Point(609, 30);
            this.button_Browse_Excel.Name = "button_Browse_Excel";
            this.button_Browse_Excel.Size = new System.Drawing.Size(25, 20);
            this.button_Browse_Excel.TabIndex = 3;
            this.button_Browse_Excel.Text = "...";
            this.button_Browse_Excel.UseVisualStyleBackColor = true;
            // 
            // button_Save_Excel
            // 
            this.button_Save_Excel.Enabled = false;
            this.button_Save_Excel.Location = new System.Drawing.Point(528, 381);
            this.button_Save_Excel.Name = "button_Save_Excel";
            this.button_Save_Excel.Size = new System.Drawing.Size(134, 29);
            this.button_Save_Excel.TabIndex = 3;
            this.button_Save_Excel.Text = "Saved";
            this.button_Save_Excel.UseVisualStyleBackColor = true;
            // 
            // button_SheetFilters_Excel
            // 
            this.button_SheetFilters_Excel.Location = new System.Drawing.Point(102, 319);
            this.button_SheetFilters_Excel.Name = "button_SheetFilters_Excel";
            this.button_SheetFilters_Excel.Size = new System.Drawing.Size(177, 34);
            this.button_SheetFilters_Excel.TabIndex = 3;
            this.button_SheetFilters_Excel.Text = "Sheet Filters";
            this.button_SheetFilters_Excel.UseVisualStyleBackColor = true;
            // 
            // radioButton_ModifiedOnly_Excel
            // 
            this.radioButton_ModifiedOnly_Excel.AutoSize = true;
            this.radioButton_ModifiedOnly_Excel.Location = new System.Drawing.Point(102, 250);
            this.radioButton_ModifiedOnly_Excel.Name = "radioButton_ModifiedOnly_Excel";
            this.radioButton_ModifiedOnly_Excel.Size = new System.Drawing.Size(124, 17);
            this.radioButton_ModifiedOnly_Excel.TabIndex = 2;
            this.radioButton_ModifiedOnly_Excel.TabStop = true;
            this.radioButton_ModifiedOnly_Excel.Text = "On modified files only";
            this.radioButton_ModifiedOnly_Excel.UseVisualStyleBackColor = true;
            this.radioButton_ModifiedOnly_Excel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox_Period_Excel
            // 
            this.textBox_Period_Excel.Location = new System.Drawing.Point(102, 212);
            this.textBox_Period_Excel.Name = "textBox_Period_Excel";
            this.textBox_Period_Excel.Size = new System.Drawing.Size(118, 20);
            this.textBox_Period_Excel.TabIndex = 1;
            // 
            // textBox_File_Excel
            // 
            this.textBox_File_Excel.Location = new System.Drawing.Point(102, 30);
            this.textBox_File_Excel.Name = "textBox_File_Excel";
            this.textBox_File_Excel.Size = new System.Drawing.Size(501, 20);
            this.textBox_File_Excel.TabIndex = 0;
            // 
            // textBox_Password_Excel
            // 
            this.textBox_Password_Excel.Location = new System.Drawing.Point(102, 108);
            this.textBox_Password_Excel.Name = "textBox_Password_Excel";
            this.textBox_Password_Excel.Size = new System.Drawing.Size(177, 20);
            this.textBox_Password_Excel.TabIndex = 0;
            // 
            // textBox_User_Excel
            // 
            this.textBox_User_Excel.Location = new System.Drawing.Point(102, 82);
            this.textBox_User_Excel.Name = "textBox_User_Excel";
            this.textBox_User_Excel.Size = new System.Drawing.Size(177, 20);
            this.textBox_User_Excel.TabIndex = 0;
            // 
            // textBox_Host_Excel
            // 
            this.textBox_Host_Excel.Location = new System.Drawing.Point(102, 56);
            this.textBox_Host_Excel.Name = "textBox_Host_Excel";
            this.textBox_Host_Excel.Size = new System.Drawing.Size(177, 20);
            this.textBox_Host_Excel.TabIndex = 0;
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.Controls.Add(this.richTextBox_Log);
            this.tabPage_Log.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Log.Size = new System.Drawing.Size(670, 416);
            this.tabPage_Log.TabIndex = 1;
            this.tabPage_Log.Text = "Log";
            this.tabPage_Log.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(19, 18);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Log.Size = new System.Drawing.Size(636, 381);
            this.richTextBox_Log.TabIndex = 0;
            this.richTextBox_Log.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_RenameConfig);
            this.Controls.Add(this.button_DeleteConfig);
            this.Controls.Add(this.button_NewConfig);
            this.Controls.Add(this.listBox_ConfigList);
            this.Name = "Form1";
            this.Text = ".: Maze - Excel Data Interface :.";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Config_Excel.ResumeLayout(false);
            this.tabPage_Config_Excel.PerformLayout();
            this.tabPage_Log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ConfigList;
        private System.Windows.Forms.Button button_NewConfig;
        private System.Windows.Forms.Button button_DeleteConfig;
        private System.Windows.Forms.Button button_RenameConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Config_Excel;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.Button button_Save_Excel;
        private System.Windows.Forms.Button button_SheetFilters_Excel;
        private System.Windows.Forms.RadioButton radioButton_ModifiedOnly_Excel;
        private System.Windows.Forms.TextBox textBox_Period_Excel;
        private System.Windows.Forms.TextBox textBox_File_Excel;
        private System.Windows.Forms.TextBox textBox_Password_Excel;
        private System.Windows.Forms.TextBox textBox_User_Excel;
        private System.Windows.Forms.TextBox textBox_Host_Excel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Browse_Excel;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
    }
}

