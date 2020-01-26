using System;
using System.IO;
using System.Text;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: ""

            //FileStream fs = new FileStream(@"C:\Users\42073\greenfox\halouzkovap\week-8-s\my-file.txt", FileMode.Create, FileAccess.Write);
            //if (fs.CanWrite)
            //{
            //    byte[] buffer = Encoding.ASCII.GetBytes("Petra");
            //    fs.Write(buffer, 0, buffer.Length);
            //}

            //fs.Flush();
            //fs.Close();
            string filePath = @"C:\Users\42073\greenfox\halouzkovap\week-8-s\my-file.txt";
            string name = "Petra";

            System.Console.WriteLine(textWriter(filePath, name));
            Console.ReadLine();
        }
        static string textWriter(string filepath, string name)
        {
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Write)
)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(name);
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Close();
                    return "OK";
                }
            }
            catch (System.Exception e)
            {

                return "Unable to write file: my-file.txt";
            }
        }

    }
}
