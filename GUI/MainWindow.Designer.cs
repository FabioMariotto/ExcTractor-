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
            this.tabControl_mainTabs = new System.Windows.Forms.TabControl();
            this.tabPage_Config_Excel = new System.Windows.Forms.TabPage();
            this.checkBox_modifiedOnly_Excel = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_NamePrefix_Excel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_browseOutPath_Excel = new System.Windows.Forms.Button();
            this.button_BrowseFile_Excel = new System.Windows.Forms.Button();
            this.button_Save_Excel = new System.Windows.Forms.Button();
            this.button_SheetFilters_Excel = new System.Windows.Forms.Button();
            this.textBox_Period_Excel = new System.Windows.Forms.TextBox();
            this.textBox_outPutPath_Excel = new System.Windows.Forms.TextBox();
            this.textBox_File_Excel = new System.Windows.Forms.TextBox();
            this.textBox_Password_Excel = new System.Windows.Forms.TextBox();
            this.textBox_User_Excel = new System.Windows.Forms.TextBox();
            this.textBox_Host_Excel = new System.Windows.Forms.TextBox();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.tabControl_mainTabs.SuspendLayout();
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
            this.listBox_ConfigList.SelectedIndexChanged += new System.EventHandler(this.listBox_ConfigList_SelectedIndexChanged);
            // 
            // button_NewConfig
            // 
            this.button_NewConfig.Location = new System.Drawing.Point(16, 365);
            this.button_NewConfig.Name = "button_NewConfig";
            this.button_NewConfig.Size = new System.Drawing.Size(145, 23);
            this.button_NewConfig.TabIndex = 1;
            this.button_NewConfig.TabStop = false;
            this.button_NewConfig.Text = "New Config";
            this.button_NewConfig.UseVisualStyleBackColor = true;
            this.button_NewConfig.Click += new System.EventHandler(this.button_NewConfig_Click);
            // 
            // button_DeleteConfig
            // 
            this.button_DeleteConfig.Location = new System.Drawing.Point(15, 423);
            this.button_DeleteConfig.Name = "button_DeleteConfig";
            this.button_DeleteConfig.Size = new System.Drawing.Size(145, 23);
            this.button_DeleteConfig.TabIndex = 1;
            this.button_DeleteConfig.TabStop = false;
            this.button_DeleteConfig.Text = "Delete Config";
            this.button_DeleteConfig.UseVisualStyleBackColor = true;
            this.button_DeleteConfig.Click += new System.EventHandler(this.button_DeleteConfig_Click);
            // 
            // button_RenameConfig
            // 
            this.button_RenameConfig.Location = new System.Drawing.Point(16, 394);
            this.button_RenameConfig.Name = "button_RenameConfig";
            this.button_RenameConfig.Size = new System.Drawing.Size(145, 23);
            this.button_RenameConfig.TabIndex = 1;
            this.button_RenameConfig.TabStop = false;
            this.button_RenameConfig.Text = "Rename Config";
            this.button_RenameConfig.UseVisualStyleBackColor = true;
            this.button_RenameConfig.Click += new System.EventHandler(this.button_RenameConfig_Click);
            // 
            // tabControl_mainTabs
            // 
            this.tabControl_mainTabs.Controls.Add(this.tabPage_Config_Excel);
            this.tabControl_mainTabs.Controls.Add(this.tabPage_Log);
            this.tabControl_mainTabs.Location = new System.Drawing.Point(178, 13);
            this.tabControl_mainTabs.Name = "tabControl_mainTabs";
            this.tabControl_mainTabs.SelectedIndex = 0;
            this.tabControl_mainTabs.Size = new System.Drawing.Size(678, 442);
            this.tabControl_mainTabs.TabIndex = 2;
            // 
            // tabPage_Config_Excel
            // 
            this.tabPage_Config_Excel.Controls.Add(this.checkBox_modifiedOnly_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.label8);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_NamePrefix_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.label6);
            this.tabPage_Config_Excel.Controls.Add(this.label5);
            this.tabPage_Config_Excel.Controls.Add(this.label4);
            this.tabPage_Config_Excel.Controls.Add(this.label3);
            this.tabPage_Config_Excel.Controls.Add(this.label2);
            this.tabPage_Config_Excel.Controls.Add(this.label7);
            this.tabPage_Config_Excel.Controls.Add(this.label1);
            this.tabPage_Config_Excel.Controls.Add(this.button_browseOutPath_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.button_BrowseFile_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.button_Save_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.button_SheetFilters_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_Period_Excel);
            this.tabPage_Config_Excel.Controls.Add(this.textBox_outPutPath_Excel);
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
            // checkBox_modifiedOnly_Excel
            // 
            this.checkBox_modifiedOnly_Excel.AutoSize = true;
            this.checkBox_modifiedOnly_Excel.Location = new System.Drawing.Point(102, 247);
            this.checkBox_modifiedOnly_Excel.Name = "checkBox_modifiedOnly_Excel";
            this.checkBox_modifiedOnly_Excel.Size = new System.Drawing.Size(109, 17);
            this.checkBox_modifiedOnly_Excel.TabIndex = 8;
            this.checkBox_modifiedOnly_Excel.Text = "Modified files only";
            this.checkBox_modifiedOnly_Excel.UseVisualStyleBackColor = true;
            this.checkBox_modifiedOnly_Excel.CheckedChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "File Name Prefix";
            // 
            // textBox_NamePrefix_Excel
            // 
            this.textBox_NamePrefix_Excel.Location = new System.Drawing.Point(102, 160);
            this.textBox_NamePrefix_Excel.Name = "textBox_NamePrefix_Excel";
            this.textBox_NamePrefix_Excel.Size = new System.Drawing.Size(118, 20);
            this.textBox_NamePrefix_Excel.TabIndex = 5;
            this.textBox_NamePrefix_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "[minutes]";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Output path";
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
            // button_browseOutPath_Excel
            // 
            this.button_browseOutPath_Excel.Enabled = false;
            this.button_browseOutPath_Excel.Location = new System.Drawing.Point(609, 186);
            this.button_browseOutPath_Excel.Name = "button_browseOutPath_Excel";
            this.button_browseOutPath_Excel.Size = new System.Drawing.Size(25, 20);
            this.button_browseOutPath_Excel.TabIndex = 3;
            this.button_browseOutPath_Excel.TabStop = false;
            this.button_browseOutPath_Excel.Text = "...";
            this.button_browseOutPath_Excel.UseVisualStyleBackColor = true;
            // 
            // button_BrowseFile_Excel
            // 
            this.button_BrowseFile_Excel.Enabled = false;
            this.button_BrowseFile_Excel.Location = new System.Drawing.Point(609, 30);
            this.button_BrowseFile_Excel.Name = "button_BrowseFile_Excel";
            this.button_BrowseFile_Excel.Size = new System.Drawing.Size(25, 20);
            this.button_BrowseFile_Excel.TabIndex = 3;
            this.button_BrowseFile_Excel.TabStop = false;
            this.button_BrowseFile_Excel.Text = "...";
            this.button_BrowseFile_Excel.UseVisualStyleBackColor = true;
            // 
            // button_Save_Excel
            // 
            this.button_Save_Excel.Enabled = false;
            this.button_Save_Excel.Location = new System.Drawing.Point(528, 381);
            this.button_Save_Excel.Name = "button_Save_Excel";
            this.button_Save_Excel.Size = new System.Drawing.Size(134, 29);
            this.button_Save_Excel.TabIndex = 9;
            this.button_Save_Excel.Text = "Saved";
            this.button_Save_Excel.UseVisualStyleBackColor = true;
            this.button_Save_Excel.Click += new System.EventHandler(this.button_Save_Excel_Click);
            // 
            // button_SheetFilters_Excel
            // 
            this.button_SheetFilters_Excel.Location = new System.Drawing.Point(102, 319);
            this.button_SheetFilters_Excel.Name = "button_SheetFilters_Excel";
            this.button_SheetFilters_Excel.Size = new System.Drawing.Size(177, 34);
            this.button_SheetFilters_Excel.TabIndex = 0;
            this.button_SheetFilters_Excel.TabStop = false;
            this.button_SheetFilters_Excel.Text = "Sheet Filters";
            this.button_SheetFilters_Excel.UseVisualStyleBackColor = true;
            // 
            // textBox_Period_Excel
            // 
            this.textBox_Period_Excel.Location = new System.Drawing.Point(102, 212);
            this.textBox_Period_Excel.Name = "textBox_Period_Excel";
            this.textBox_Period_Excel.Size = new System.Drawing.Size(118, 20);
            this.textBox_Period_Excel.TabIndex = 7;
            this.textBox_Period_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // textBox_outPutPath_Excel
            // 
            this.textBox_outPutPath_Excel.Location = new System.Drawing.Point(102, 186);
            this.textBox_outPutPath_Excel.Name = "textBox_outPutPath_Excel";
            this.textBox_outPutPath_Excel.Size = new System.Drawing.Size(501, 20);
            this.textBox_outPutPath_Excel.TabIndex = 6;
            this.textBox_outPutPath_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // textBox_File_Excel
            // 
            this.textBox_File_Excel.Location = new System.Drawing.Point(102, 30);
            this.textBox_File_Excel.Name = "textBox_File_Excel";
            this.textBox_File_Excel.Size = new System.Drawing.Size(501, 20);
            this.textBox_File_Excel.TabIndex = 1;
            this.textBox_File_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // textBox_Password_Excel
            // 
            this.textBox_Password_Excel.Location = new System.Drawing.Point(102, 108);
            this.textBox_Password_Excel.Name = "textBox_Password_Excel";
            this.textBox_Password_Excel.Size = new System.Drawing.Size(177, 20);
            this.textBox_Password_Excel.TabIndex = 4;
            this.textBox_Password_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // textBox_User_Excel
            // 
            this.textBox_User_Excel.Location = new System.Drawing.Point(102, 82);
            this.textBox_User_Excel.Name = "textBox_User_Excel";
            this.textBox_User_Excel.Size = new System.Drawing.Size(177, 20);
            this.textBox_User_Excel.TabIndex = 3;
            this.textBox_User_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
            // 
            // textBox_Host_Excel
            // 
            this.textBox_Host_Excel.Location = new System.Drawing.Point(102, 56);
            this.textBox_Host_Excel.Name = "textBox_Host_Excel";
            this.textBox_Host_Excel.Size = new System.Drawing.Size(177, 20);
            this.textBox_Host_Excel.TabIndex = 2;
            this.textBox_Host_Excel.TextChanged += new System.EventHandler(this.ExcelTab_AnyElement_ValueChanged);
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
            this.richTextBox_Log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 2);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Log.Size = new System.Drawing.Size(668, 414);
            this.richTextBox_Log.TabIndex = 0;
            this.richTextBox_Log.Text = "";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.tabControl_mainTabs);
            this.Controls.Add(this.button_RenameConfig);
            this.Controls.Add(this.button_DeleteConfig);
            this.Controls.Add(this.button_NewConfig);
            this.Controls.Add(this.listBox_ConfigList);
            this.Name = "Form_Main";
            this.Text = ".: Maze - Excel Data Interface :.";
            this.tabControl_mainTabs.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl_mainTabs;
        private System.Windows.Forms.TabPage tabPage_Config_Excel;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.Button button_Save_Excel;
        private System.Windows.Forms.Button button_SheetFilters_Excel;
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
        private System.Windows.Forms.Button button_BrowseFile_Excel;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_browseOutPath_Excel;
        private System.Windows.Forms.TextBox textBox_outPutPath_Excel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_NamePrefix_Excel;
        private System.Windows.Forms.CheckBox checkBox_modifiedOnly_Excel;
    }
}

