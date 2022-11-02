using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolProject.Scripts
{
    public static class FileHelper
    {

        public static class FileReader
        {
            public static string ReadAllTextFile(string path)
            {
                return File.ReadAllText(path);
            }

            public static List<string> ReadLinesList(string path)
            {
                List<string> lines = new List<string>();
                StreamReader sr = new StreamReader(path);

                string? line = "";
                while ((line = sr.ReadLine()) != null)
                    lines.Add(line);

                sr.Close();

                return lines;
            }

            public static string? ReadLine(string path, int index)
            {
                string? text = "";

                StreamReader sr = new StreamReader(path);

                int contor = 0;
                while( (text = sr.ReadLine()) != null)
                {
                    if (contor == index)
                        return text;

                    contor++;
                }

                sr.Close();

                return null;
            }

            public static bool FileExists(string path)
            {
                return File.Exists(path);
            }
        }



        public static class FileWriter
        {

            public static void Write(string path, string text)
            {
                File.WriteAllText(path, text);
            }

        }

    }
}
