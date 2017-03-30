using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcTractor.GUI
{
    public partial class Form_NewConfig : Form
    {

        public string Choosen_Name;

        public Form_NewConfig()
        {
            InitializeComponent();
            listBox_ConfigTypes.Items.Add("Excel File");
        }

        private void textBox_ConfigName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            
            if (textBox_ConfigName.Text != "não é repetido") //<----
            {
                Choosen_Name = textBox_ConfigName.Text;
                DialogResult = DialogResult.OK;
            }                                 
            else
                MessageBox.Show("Config name already in use.");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
