using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcTractor
{
    public static class LogFile
    {

        public static string InstalPath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// Returns all text from the LOG file
        /// </summary>
        /// <returns></returns>
        private static string read_LogFile()
        {

            //string LogFile = Directory.GetCurrentDirectory() + "\\Log.txt";
            string LogFile = InstalPath + "\\Log.txt";


            if (File.Exists(LogFile) == true)
            {
                StreamReader configReader;
                configReader = new StreamReader(LogFile);
                string returnString = configReader.ReadToEnd();
                configReader.Close();
                return returnString;
            }
            else
            {
                File.WriteAllText(LogFile, "");
                return "";
            }
        }

        /// <summary>
        /// Writes text to the Log file
        /// </summary>
        /// <param name="text">text to be writen</param>
        /// <param name="append">append?(default=true)</param>
        public static void write_LogFile(string text, bool append = true)
        {

            try
            {
                //string LogFile = Directory.GetCurrentDirectory() + "\\Log.txt";
                string LogFile = InstalPath + "\\Log.txt";


                if (File.Exists(LogFile) == true)
                {
                    StreamWriter configWriter;
                    configWriter = new StreamWriter(LogFile, append);
                    configWriter.Write("\r\n" + DateTime.Now.ToString() + "; " + text);
                    configWriter.Close();
                }
                else
                {
                    File.WriteAllText(LogFile, text);
                }
            }
            catch { }
        }

        /// <summary>
        /// Writes exception to the log file
        /// </summary>
        /// <param name="except"></param>
        public static void write_LogFile(Exception except, bool append = true)
        {

            try
            {
                //string LogFile = Directory.GetCurrentDirectory() + "\\Log.txt";
                string LogFile = InstalPath + "\\Log.txt";

                if (File.Exists(LogFile) == true)
                {
                    StreamWriter configWriter;
                    configWriter = new StreamWriter(LogFile, append);
                    configWriter.Write("\r\n" + DateTime.Now.ToString() + "; " + except.Source.ToString().Trim() + ": " + except.Message.ToString().Trim());
                    configWriter.Close();
                }
                else
                {
                    File.WriteAllText(LogFile, DateTime.Now.ToString() + "; " + except.Source.ToString().Trim() + ": " + except.Message.ToString().Trim());
                }
            }
            catch { }
        }







    }
}
