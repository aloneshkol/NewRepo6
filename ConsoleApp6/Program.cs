using System;
using System.IO;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\MyTest.txt";

            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(path, 1024))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("This is some text sin the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
