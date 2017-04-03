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

        string ExcelTypeConfig = "Excel File";

        public Form_Main()
        {
            InitializeComponent();
            tabControl_mainTabs.TabPages.Clear();
            UpdateConfigList();

        }


        //User clicks on CREATE NEW CONFIG button
        private void button_NewConfig_Click(object sender, EventArgs e)
        {
            Form_NewConfig formnewConfig = new Form_NewConfig();
            formnewConfig.ShowDialog();
            if (formnewConfig.DialogResult == DialogResult.OK)
            {

                tabControl_mainTabs.TabPages.Clear();

                if (formnewConfig.Choosen_Config == ExcelTypeConfig)
                {
                    tabControl_mainTabs.TabPages.Add(tabPage_Config_Excel);
                    tabControl_mainTabs.TabPages.Add(tabPage_Log);
                    textBox_Host_Excel.Text = "127.0.0.1";
                    textBox_Period_Excel.Text = "3";
                    checkBox_modifiedOnly_Excel.Checked = true;
                    //MessageBox.Show(formnewConfig.Choosen_Config);
                    ConfigFile.CreateNewConfig(formnewConfig.Choosen_Name);
                    ConfigFile.write_atribute(formnewConfig.Choosen_Name, "Host", "127.0.0.1");
                    ConfigFile.write_atribute(formnewConfig.Choosen_Name, "Type", ExcelTypeConfig);

                }
                listBox_ConfigList.Items.Add(formnewConfig.Choosen_Name);
                listBox_ConfigList.SelectedIndex = listBox_ConfigList.Items.Count - 1;
 

            }
            formnewConfig.Close();
            formnewConfig.Dispose();
            tabControl_mainTabs.Enabled = true;
            
        }


        //User clicks on DELETE CONFIG button
        private void button_DeleteConfig_Click(object sender, EventArgs e)
        {
            if (listBox_ConfigList.SelectedIndex != -1)
            {
                if (MessageBox.Show("Delete config \"" + listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem) + "\"?", "Deleting Config", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ConfigFile.DeleteConfig(listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem));
                    UpdateConfigList();
                }
            }
        }

        //User clicks on RENAME CONFIG button
        private void button_RenameConfig_Click(object sender, EventArgs e)
        {
            if (listBox_ConfigList.SelectedIndex != -1)
            {
                Form_RenameConfig formRenameConfig = new Form_RenameConfig(listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem));
                formRenameConfig.ShowDialog();
                if (formRenameConfig.DialogResult == DialogResult.OK)
                {
                    int i = listBox_ConfigList.SelectedIndex;
                    ConfigFile.RenameConfig(listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem), formRenameConfig.Choosen_Name);
                    UpdateConfigList();
                    listBox_ConfigList.SelectedIndex = i;
                }
            }
        }
        //Reloads the list of configurations from config file and update the listbox
        private void UpdateConfigList()
        {
            listBox_ConfigList.Items.Clear();
            foreach (string configName in ConfigFile.ConfigNames())
            {
                listBox_ConfigList.Items.Add(configName);
            }
            tabControl_mainTabs.Enabled = false;
            if (listBox_ConfigList.Items.Count > 0)
            {
                listBox_ConfigList.SelectedIndex = 0;
                tabControl_mainTabs.Enabled = true;
            }
        }

        //Event when any text box on EXCEL tab value is changed
        private void ExcelTab_AnyElement_ValueChanged(object sender, EventArgs e)
        {
            button_Save_Excel.Enabled = true;
            button_Save_Excel.Text = "Save";
        }

        private void listBox_ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ConfigList.SelectedIndex != -1)
            {
                string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
                string tipo = ConfigFile.read_atribute(configName, "Type");
                tabControl_mainTabs.TabPages.Clear();

                if (tipo == ExcelTypeConfig)
                {
                    textBox_File_Excel.Text = ConfigFile.read_atribute(configName, "FilePath");
                    textBox_Host_Excel.Text = ConfigFile.read_atribute(configName, "Host");
                    textBox_User_Excel.Text = ConfigFile.read_atribute(configName, "User");
                    textBox_Password_Excel.Text = ConfigFile.read_atribute(configName, "Password");
                    textBox_outPutPath_Excel.Text = ConfigFile.read_atribute(configName, "Destination");
                    textBox_Period_Excel.Text = ConfigFile.read_atribute(configName, "Period");
                    textBox_NamePrefix_Excel.Text = ConfigFile.read_atribute(configName, "NamePrefix");
                    if (ConfigFile.read_atribute(configName, "ModifiedOnly") == "1")
                       checkBox_modifiedOnly_Excel.Checked = true;
                    else
                        checkBox_modifiedOnly_Excel.Checked = false;
                    tabControl_mainTabs.TabPages.Add(tabPage_Config_Excel);
                    tabControl_mainTabs.TabPages.Add(tabPage_Log);
                    button_Save_Excel.Enabled = false;
                    button_Save_Excel.Text = "Saved";
                }
                else if (tipo == "outro tipo de config especifico")
                {

                }

            }
                
        }

        private void button_Save_Excel_Click(object sender, EventArgs e)
        {
            string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
            string tipo = ConfigFile.read_atribute(configName, "Type");

            if (tipo == ExcelTypeConfig)
            {
                ConfigFile.write_atribute(configName, "FilePath", textBox_File_Excel.Text);
                ConfigFile.write_atribute(configName, "Host", textBox_Host_Excel.Text);
                ConfigFile.write_atribute(configName, "User", textBox_User_Excel.Text);
                ConfigFile.write_atribute(configName, "Password", textBox_Password_Excel.Text);
                ConfigFile.write_atribute(configName, "Destination", textBox_outPutPath_Excel.Text);
                ConfigFile.write_atribute(configName, "Period", textBox_Period_Excel.Text);
                ConfigFile.write_atribute(configName, "NamePrefix", textBox_NamePrefix_Excel.Text);
                if (checkBox_modifiedOnly_Excel.Checked == true)
                    ConfigFile.write_atribute(configName, "ModifiedOnly", "1");
                else
                    ConfigFile.write_atribute(configName, "ModifiedOnly", "0");
                button_Save_Excel.Enabled = false;
                button_Save_Excel.Text = "Saved";
            }

        }
    }
}
