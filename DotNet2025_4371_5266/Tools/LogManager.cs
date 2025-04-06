using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string logPath = "Log";

        /// <summary>
        /// פונקיצה להחזרת הניותב של התיקיה
        /// </summary>
        public static string GetFolderPath()
        {
            string folderPath = @$"{logPath}\{DateTime.Now.Year}_{DateTime.Now.Month}";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        /// <summary>
        /// פונקיצה להחזרת הניתוב של הקובץ
        /// </summary>
        public static string GetFilePath()
        {
            string folderPath = GetFolderPath();
            string filePath = @$"{folderPath}\Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            return filePath;
        }

        public static void Log(string nameProject, string func, string message)
        {
            string fileName = GetFilePath();
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"{DateTime.Now}\t{nameProject}.{func}:\t\t{message}");
            }
        }


        public static void CleanLog()
        {
            string[] subDirectories = Directory.GetDirectories(logPath);
            foreach (string dir in subDirectories)
            {
                string folderName = Path.GetFileName(dir);
                if (folderName.Length >= 7 && int.TryParse(folderName.Substring(0, 4), out int year) && int.TryParse(folderName.Substring(5, 2), out int month))
                {
                    DateTime folderDate = new DateTime(year, month, 1);
                    if (folderDate < DateTime.Now.AddMonths(-2))
                    {
                        Directory.Delete(dir, true);
                    }
                }
            }
        }
    }
}
