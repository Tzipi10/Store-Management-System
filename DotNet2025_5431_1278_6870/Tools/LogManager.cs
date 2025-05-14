using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace Tools
{
    public static class LogManager
    {
        private static readonly string PATH = "Log";

        public static string getCurrentDir()
        {
           //Console.WriteLine(Directory.GetCurrentDirectory());
           return Directory.GetCurrentDirectory();
        }
        public static string getCurrentFile()
        {
            return $@"{getCurrentDir()}\Log\{DateTime.Now.Month}\{DateTime.Now.Day}.txt";
        }

        public static void writeToLog(string projectName, string funcName, string message)
        {
            String directoryPath = $"{getCurrentDir()}\\log\\{DateTime.Now.Month}";
            String currentFile =getCurrentFile();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(currentFile))
            {
                File.Create(currentFile).Close();
            }
            using (StreamWriter writeText = new StreamWriter(currentFile,true))
            {
                writeText.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
            }
        }

        public static void clearLog()
        {
            try
            {
                DirectoryInfo[] directories = Directory.CreateDirectory($"{getCurrentDir()}\\log").GetDirectories();
                foreach (DirectoryInfo directory in directories)
                {
                    if (directory.Name != DateTime.Now.Month.ToString() && directory.Name != DateTime.Now.AddMonths(-1).Month.ToString())
                    {
                        directory.Delete();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
    }
}
