namespace ExcTractor.GUI
{
    partial class Form_NewConfig
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
            this.listBox_ConfigTypes = new System.Windows.Forms.ListBox();
            this.textBox_ConfigName = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_ConfigTypes
            // 
            this.listBox_ConfigTypes.FormattingEnabled = true;
            this.listBox_ConfigTypes.Location = new System.Drawing.Point(33, 56);
            this.listBox_ConfigTypes.Name = "listBox_ConfigTypes";
            this.listBox_ConfigTypes.Size = new System.Drawing.Size(185, 17);
            this.listBox_ConfigTypes.TabIndex = 0;
            // 
            // textBox_ConfigName
            // 
            this.textBox_ConfigName.Location = new System.Drawing.Point(33, 20);
            this.textBox_ConfigName.Name = "textBox_ConfigName";
            this.textBox_ConfigName.Size = new System.Drawing.Size(185, 20);
            this.textBox_ConfigName.TabIndex = 1;
            this.textBox_ConfigName.Text = "Choose a name";
            this.textBox_ConfigName.TextChanged += new System.EventHandler(this.textBox_ConfigName_TextChanged);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(43, 91);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(68, 24);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(134, 91);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(68, 24);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form_NewConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 132);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_ConfigName);
            this.Controls.Add(this.listBox_ConfigTypes);
            this.Name = "Form_NewConfig";
            this.Text = "Creating New Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ConfigTypes;
        private System.Windows.Forms.TextBox textBox_ConfigName;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Cancel;
    }
}