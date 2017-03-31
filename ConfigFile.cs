using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExcTractor
{
    public static class ConfigFile
    {
        
        
        //Get the value of a atribute from one configuration
        public static string load_atribute(string config_name, string atribute_name)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);


                if (doc.SelectSingleNode("/"+config_name).Attributes[atribute_name] != null)
                {
                    return doc.SelectSingleNode("/" + config_name).Attributes[atribute_name].Value;
                }
                else
                {
                    //LOG ERROR>> atribute not found
                    return "";
                }
            }
            else
            {
                //Creates new file with null text
                File.WriteAllText(ConfigFile, "");
                //LOG ERROR>> config file not found
                return "";
            }
            
        }

        internal static void CreateNewConfig(string m_Configname)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);
                XmlNode ConfigNode = doc.CreateElement("Config");
                XmlAttribute ConfigName = doc.CreateAttribute("Name");
                doc.DocumentElement.AppendChild(ConfigNode);
                ConfigNode.Attributes.Append(ConfigName);
                ConfigName.Value = m_Configname;
                doc.Save(ConfigFile);
            }
            else
            {
                //LOG ERROR>> config file not found during creation of new config
            }

        }

        internal static void DeleteConfig(string m_Configname)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);

                foreach (XmlNode itemNode in doc.SelectNodes("/AllConfig/Config"))
                {
                    if (itemNode.Attributes["Name"] != null && itemNode.Attributes["Name"].Value == m_Configname)
                    {
                        doc.DocumentElement.RemoveChild(itemNode);
                        doc.Save(ConfigFile);
                        return;
                    }
                }
            }
            else
            {
                //LOG ERROR>> config file not found during creation of new config
            }

        }

        /// <summary>
        /// Returns a List fo Strings with all Config Names from the config File.
        /// </summary>
        /// <returns></returns>
        internal static List<string> ConfigNames()
        {
            List<string> configNames = new List<string>();
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);

                foreach (XmlNode itemNode in doc.SelectNodes("/AllConfig/Config"))
                {
                    if (itemNode.Attributes["Name"] != null)
                        configNames.Add(itemNode.Attributes["Name"].Value);
                }
      
            }
            else
            {
                //LOG ERROR>> config file not found during creation of new config

            }
            return configNames;
        }

        internal static void RenameConfig(string m_Configname, string m_NewConfigname)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);

                foreach (XmlNode itemNode in doc.SelectNodes("/AllConfig/Config"))
                {
                    if (itemNode.Attributes["Name"] != null && itemNode.Attributes["Name"].Value == m_Configname)
                    {
                        itemNode.Attributes["Name"].Value = m_NewConfigname;
                        doc.Save(ConfigFile);
                        return;
                    }
                }
            }
            else
            {
                //LOG ERROR>> config file not found during creation of new config
            }

        }


        //Writes a value to a atribute of a configuration
        public static bool write_atribute(string config_name, string atribute_name, string value)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);

                foreach (XmlNode itemNode in doc.SelectNodes("/AllConfig/Config"))
                {
                    if (itemNode.Attributes["Name"] != null && itemNode.Attributes["Name"].Value == config_name)
                    {
                        if (itemNode.Attributes[atribute_name] != null)
                        {
                            itemNode.Attributes[atribute_name].Value = value;
                        }
                        else
                        {
                            XmlAttribute ConfigName = doc.CreateAttribute(atribute_name);
                            ConfigName.Value = value;
                            itemNode.Attributes.Append(ConfigName);
                        }
                        doc.Save(ConfigFile);
                        return true;
                    }
                }
                //LOG ERROR>> CONFIG NAME DOEST EXIST INSIDE XML FILE
                return false;
            }
            //LOG ERROR>> config file not found
            return false;
        }

        public static string read_atribute(string config_name, string atribute_name)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigFile);

                foreach (XmlNode itemNode in doc.SelectNodes("/AllConfig/Config"))
                {
                    if (itemNode.Attributes["Name"] != null && itemNode.Attributes["Name"].Value == config_name)
                    {
                        if (itemNode.Attributes[atribute_name] != null)
                        {
                            return itemNode.Attributes[atribute_name].Value;
                        }
                        else
                        {
                            return "";
                        }

                    }
                }
                //LOG ERROR>> CONFIG NAME DOEST EXIST INSIDE XML FILE
                return "";
            }
            //LOG ERROR>> config file not found
            return "";
        }




    }
}
