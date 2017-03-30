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
            if (File.Exists(ConfigFile) == true)
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

        //Writes a value to a atribute of a configuration
        public static bool write_atribute(string config_name, string atribute_name, string vaue)
        {
            string ConfigFile = Directory.GetCurrentDirectory() + "\\Configuration.xml";
            if (File.Exists(ConfigFile) != true)
            {


            }
        }


    }
}
