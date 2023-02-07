using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private StreamWriter writer;

        Singleton()
        {
            string fileName = "log.txt";
            string path = @"C:\MyTextFiles";
            string fullPath = Path.Combine(path, fileName);

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }

                using (StreamReader sr = new StreamReader(fileName))
                {

                }

                MessageBox.Show("Файл зробленно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string filePath = @"C:\MyTextFiles\log.txt";

            writer = new StreamWriter(filePath, true);
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            writer.WriteLine(DateTime.Now + ": " + message);
            writer.Flush();
        }
    }
}
