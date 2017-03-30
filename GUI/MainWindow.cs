using ExcTractor.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcTractor
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //User clicks on Create New config button
        private void button_NewConfig_Click(object sender, EventArgs e)
        {
            Form_NewConfig formnewConfig = new Form_NewConfig();
            formnewConfig.ShowDialog();
            if (formnewConfig.DialogResult == DialogResult.OK)
            {


                //listboxConfigs.Items.Add(formnewConfig.enteredName());
                //listboxConfigs.SelectedIndex = listboxConfigs.Items.Count - 1;
                //string configparams = "[" + formnewConfig.enteredName() + "]";
                //configparams = configparams + "\r\n" + "dataFreq=60000";
                //configparams = configparams + "\r\n" + "fileFreq=60000";
                //configparams = configparams + "\r\n" + "piLogin=";
                //configparams = configparams + "\r\n" + "piPass=";
                //configparams = configparams + "\r\n" + "piHost=";
                //configparams = configparams + "\r\n" + "piPort=5450";
                //configparams = configparams + "\r\n" + "outFile=" + "\r\n";
                //string saveResult = formMain.writeConfigFile(configparams, true);
                //string tagsFile = installPath + "\\" + formnewConfig.enteredName() + ".tags";
                ////MessageBox.Show(tagsFile);
                //File.Create(tagsFile).Dispose();
                ////File.WriteAllText(tagsFile, "");
                //loadSelectedtags();

            }
            formnewConfig.Close();
            formnewConfig.Dispose();
            //showConfig();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_DeleteConfig_Click(object sender, EventArgs e)
        {

        }

        private void button_RenameConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
