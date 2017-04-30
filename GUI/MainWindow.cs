using ExcTractor.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcTractor
{
    public partial class Form_Main : Form
    {

        public Form_Main()
        {
            InitializeComponent();
            tabControl_mainTabs.TabPages.Clear();
            UpdateConfigList();
            Thread T = new Thread(new ThreadStart(() => updateLogText()));
            T.IsBackground = true;
            T.Start();

        }

        //Commnn controls for the main window
        #region Main window controls

        //updates the log window every 3 seconds
        private void updateLogText()
        {
            string lastWrite = "";
            while (true)
            {
                Support.CreateFile(LogFile.LogFilename);

                FileInfo FileInfo = new FileInfo(LogFile.LogFilePath);
                if (FileInfo.LastWriteTime.ToString() != lastWrite)
                {
                    lastWrite = FileInfo.LastWriteTime.ToString();
                    string text = "";
                    string[] lines = Support.getFileLines(LogFile.LogFilename);
                    for (int i = lines.Length - 1; i >= 0; i--)
                    {
                        text = text + lines[i] + Environment.NewLine;
                    }
                   richTextBox_Log.Text = text;
                }
                
                System.Threading.Thread.Sleep(3000);
            }
        }

        //User clicks on CREATE NEW CONFIG button
        private void button_NewConfig_Click(object sender, EventArgs e)
        {
            Form_NewConfig formnewConfig = new Form_NewConfig();
            formnewConfig.ShowDialog();
            if (formnewConfig.DialogResult == DialogResult.OK)
            {

                tabControl_mainTabs.TabPages.Clear();

                if (formnewConfig.Choosen_Config == ConfigFile.TypeConfig_Excel)
                {
                    tabControl_mainTabs.TabPages.Add(tabPage_Config_Excel);
                    tabControl_mainTabs.TabPages.Add(tabPage_Log);
            
                    ConfigFile.CreateNewConfig(formnewConfig.Choosen_Name);
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.AttribExcel_Host, "127.0.0.1");
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.AttribExcel_Period, "5");
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.AttribExcel_ModifiedOnly, "1");
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.Attrib_Type, ConfigFile.TypeConfig_Excel);

                }
                else if(formnewConfig.Choosen_Config == ConfigFile.TypeConfig_ACCDB)
                {
                    tabControl_mainTabs.TabPages.Add(tabPage_Config_ACCDB);
                    tabControl_mainTabs.TabPages.Add(tabPage_Log);

                    ConfigFile.CreateNewConfig(formnewConfig.Choosen_Name);
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.AttribAccdb_Host, "127.0.0.1");
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.AttribAccdb_Period, "60");
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.AttribAccdb_ModifiedOnly, "1");
                    ConfigFile.write_attribute(formnewConfig.Choosen_Name, ConfigFile.Attrib_Type, ConfigFile.TypeConfig_ACCDB);
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
                    Support.DeleteFile(Support.WhitelistFilePrefix + listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem) + ".txt");
                    Support.DeleteFile(Support.TablelistFilePrefix + listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem) + ".txt");
                    ConfigFile.DeleteConfig(listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem));
                    UpdateConfigList();
                }
            }
        }

        private void button_restartService_Click(object sender, EventArgs e)
        {
            ServiceController serviceController = new ServiceController("MAZE");
            try
            {
                
                if ((serviceController.Status.Equals(ServiceControllerStatus.Running)) || (serviceController.Status.Equals(ServiceControllerStatus.StartPending)))
                {
                    serviceController.Stop();
                }
                button_restartService.Enabled = false;
                button_restartService.Text = "Restarting...";
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                serviceController.Start();
                serviceController.WaitForStatus(ServiceControllerStatus.Running);
                button_restartService.Enabled = true;
                button_restartService.Text = "Restart Service";
                button_StopService.Enabled = true;
                button_StopService.Text = "Stop Service";
            }
            catch (Exception exc)
            {
                LogFile.write_LogFile("Error trying to restart service:"+exc.Message);
            }
        }

        private void button_stopService_Click(object sender, EventArgs e)
        {
            ServiceController serviceController = new ServiceController("MAZE");
            try
            {

                if ((serviceController.Status.Equals(ServiceControllerStatus.Running)) || (serviceController.Status.Equals(ServiceControllerStatus.StartPending)))
                {
                    
                    serviceController.Stop();
                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                    button_StopService.Enabled = false;
                    button_StopService.Text = "Service stopped";

                }
            }
            catch (Exception exc)
            {
                LogFile.write_LogFile("Error trying to stop service:" + exc.Message);
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
                    Support.RenameFile(Support.WhitelistFilePrefix + listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem) + ".txt", Support.WhitelistFilePrefix + formRenameConfig.Choosen_Name + ".txt");
                    Support.RenameFile(Support.TablelistFilePrefix + listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem) + ".txt", Support.TablelistFilePrefix + formRenameConfig.Choosen_Name + ".txt");
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

        //When the selected config is changed
        private void listBox_ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ConfigList.SelectedIndex != -1)
            {
                string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
                string tipo = ConfigFile.read_attribute(configName, ConfigFile.Attrib_Type);
                tabControl_mainTabs.TabPages.Clear();

                if (tipo == ConfigFile.TypeConfig_Excel)
                {
                    textBox_File_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_FilePath);
                    textBox_Host_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_Host);
                    textBox_User_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_User);
                    textBox_Password_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_Password);
                    textBox_outPutPath_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_Destination);
                    textBox_Period_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_Period);
                    textBox_NamePrefix_Excel.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_NamePrefix);
                    if (ConfigFile.read_attribute(configName, ConfigFile.AttribExcel_ModifiedOnly) == "1")
                        checkBox_modifiedOnly_Excel.Checked = true;
                    else
                        checkBox_modifiedOnly_Excel.Checked = false;
                    tabControl_mainTabs.TabPages.Add(tabPage_Config_Excel);
                    tabControl_mainTabs.TabPages.Add(tabPage_Log);
                    button_Save_Excel.Enabled = false;
                    button_Save_Excel.Text = "Saved";
                }
                else if (tipo == ConfigFile.TypeConfig_ACCDB)
                {
                    textBox_accdbFile_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_FilePath);
                    textBox_host_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_Host);
                    textBox_user_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_User);
                    textBox_password_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_Password);
                    textBox_output_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_Destination);
                    textBox_period_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_Period);
                    textBox_namePrefix_accdb.Text = ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_NamePrefix);
                    if (ConfigFile.read_attribute(configName, ConfigFile.AttribAccdb_ModifiedOnly) == "1")
                        checkBox_modifiedOnly_accdb.Checked = true;
                    else
                        checkBox_modifiedOnly_accdb.Checked = false;
                    tabControl_mainTabs.TabPages.Add(tabPage_Config_ACCDB);
                    tabControl_mainTabs.TabPages.Add(tabPage_Log);
                    button_save_accdb.Enabled = false;
                    button_save_accdb.Text = "Saved";
                }

            }

        }

        #endregion

        //Excel tab controls
        #region EXCEL TAB CONFIGS

        //Event when any text box on EXCEL tab value is changed
        private void ExcelTab_AnyElement_ValueChanged(object sender, EventArgs e)
        {
            button_Save_Excel.Enabled = true;
            button_Save_Excel.Text = "Save";
        }

        
        //when excel config is saved
        private void button_Save_Excel_Click(object sender, EventArgs e)
        {
            string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
            string tipo = ConfigFile.read_attribute(configName, ConfigFile.Attrib_Type);

            if (tipo == ConfigFile.TypeConfig_Excel)
            {
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_FilePath, textBox_File_Excel.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_Host, textBox_Host_Excel.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_User, textBox_User_Excel.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_Password, textBox_Password_Excel.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_Destination, textBox_outPutPath_Excel.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_Period, textBox_Period_Excel.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_NamePrefix, textBox_NamePrefix_Excel.Text);
                if (checkBox_modifiedOnly_Excel.Checked == true)
                    ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_ModifiedOnly, "1");
                else
                    ConfigFile.write_attribute(configName, ConfigFile.AttribExcel_ModifiedOnly, "0");
                button_Save_Excel.Enabled = false;
                button_Save_Excel.Text = "Saved";
            }

        }

        //Opens whitelist file
        private void button_SheetFilters_Excel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_ConfigList.SelectedIndex != -1)
                {
                    string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
                    string tableFilePath = Support.InstalPath + "\\" + Support.WhitelistFilePrefix + configName + ".txt";

                    Support.CreateFile(Support.WhitelistFilePrefix + configName + ".txt");
                    Process p = Process.Start(tableFilePath);
                    //p.WaitForExit();
                    return;
                }

            }
            catch (Exception exp)
            {
                LogFile.write_LogFile("Error trying to open WhiteList: " + exp.Message);
            }
            return;
        }

        //opens browser to select output folder
        private void button_browseOutPath_Excel_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_output_Excel.SelectedPath = AppDomain.CurrentDomain.BaseDirectory; // Directory.GetCurrentDirectory();
            folderBrowserDialog_output_Excel.Description = "Output destination folder";

            if (folderBrowserDialog_output_Excel.ShowDialog() != DialogResult.Cancel)
            {
                textBox_outPutPath_Excel.Text = folderBrowserDialog_output_Excel.SelectedPath+"\\";
            }
        }

        //opens file browser to select excel file
        private void button_BrowseFile_Excel_Click(object sender, EventArgs e)
        {
            openFileDialog_ExcelFile_Excel.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog_ExcelFile_Excel.ShowDialog() != DialogResult.Cancel)
            {
                textBox_File_Excel.Text = openFileDialog_ExcelFile_Excel.FileName;
            }
        }

        #endregion

        //ACCDB tab controls
        #region ACCDB TAB CONFIGS

        //Event when any text box on accdb tab value is changed
        private void accdbTab_AnyElement_ValueChanged(object sender, EventArgs e)
        {
            button_save_accdb.Enabled = true;
            button_save_accdb.Text = "Save";
        }


        //when ACCDB config is saved
        private void button_Save_accdb_click(object sender, EventArgs e)
        {
            string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
            string tipo = ConfigFile.read_attribute(configName, ConfigFile.Attrib_Type);

            if (tipo == ConfigFile.TypeConfig_ACCDB)
            {
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_FilePath, textBox_accdbFile_accdb.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_Host, textBox_host_accdb.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_User, textBox_user_accdb.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_Password, textBox_password_accdb.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_Destination, textBox_output_accdb.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_Period, textBox_period_accdb.Text);
                ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_NamePrefix, textBox_namePrefix_accdb.Text);
                if (checkBox_modifiedOnly_accdb.Checked == true)
                    ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_ModifiedOnly, "1");
                else
                    ConfigFile.write_attribute(configName, ConfigFile.AttribAccdb_ModifiedOnly, "0");
                button_save_accdb.Enabled = false;
                button_save_accdb.Text = "Saved";
            }

        }

        //Opens tablelist file
        private void button_tableFilters_accdb_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox_ConfigList.SelectedIndex != -1)
                {
                    string configName = listBox_ConfigList.GetItemText(listBox_ConfigList.SelectedItem);
                    string tableFilePath = Support.InstalPath + "\\" + Support.TablelistFilePrefix + configName + ".txt";

                    Support.CreateFile(Support.TablelistFilePrefix + configName + ".txt");
                    Process p = Process.Start(tableFilePath);
                    //p.WaitForExit();
                    return;
                }

            }
            catch (Exception exp)
            {
                LogFile.write_LogFile("Error trying to open TableList: "+exp.Message);
            }
            return;
        }

        //opens browser to select output folder
        private void button_browseOutPath_accdb_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_output_Excel.SelectedPath = AppDomain.CurrentDomain.BaseDirectory; // Directory.GetCurrentDirectory();
            folderBrowserDialog_output_Excel.Description = "Output destination folder";

            if (folderBrowserDialog_output_Excel.ShowDialog() != DialogResult.Cancel)
            {
                textBox_output_accdb.Text = folderBrowserDialog_output_Excel.SelectedPath + "\\";
            }
        }

        //opens file browser to select accdb file file
        private void button_BrowseFile_accdb_Click(object sender, EventArgs e)
        {
            openFileDialog_ExcelFile_Excel.Filter = "Access 2000-2003 (*.mdb)|*.mdb|Access 2007 (*.accdb)|*accdb";
            if (openFileDialog_ExcelFile_Excel.ShowDialog() != DialogResult.Cancel)
            {
                textBox_accdbFile_accdb.Text = openFileDialog_ExcelFile_Excel.FileName;
            }
        }


        #endregion

        
    }
}
