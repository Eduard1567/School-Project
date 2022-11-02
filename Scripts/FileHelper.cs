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
                return new StreamReader(path).ReadToEnd();
            }

            public static List<string> ReadLinesList(string path)
            {
                List<string> lines = new List<string>();
                StreamReader sr = new StreamReader(path);

                string? line = "";
                while ((line = sr.ReadLine()) != null)
                    lines.Add(line);

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

                return null;
            }
        }



        public static class FileWriter
        {

            public static void Write(string path, string text)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write(text);
            }

        }

    }
}
