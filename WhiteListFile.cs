using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcTractor
{
    public static class WhiteListFile
    {
        private static string InstalPath = AppDomain.CurrentDomain.BaseDirectory;

        public static string[] getWhitelistLines(string configName)
        {
            try
            {
                return System.IO.File.ReadAllLines(InstalPath+"\\Whitelist_"+ configName+".txt", Encoding.UTF8);
            }
            catch (Exception e)
            {
                return new string[] { "expetion getting white list lines: " + e.Message };
            }

        }


        private static void WriteLine(string configName, string text, bool append=true)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(InstalPath + "\\Whitelist_" + configName + ".txt", append, Encoding.UTF8);
                if (text != "") Writer.WriteLine(text);
                Writer.Flush();
                Writer.Close();
            }
            catch
            {
                throw;
            }
        }



    }
}
