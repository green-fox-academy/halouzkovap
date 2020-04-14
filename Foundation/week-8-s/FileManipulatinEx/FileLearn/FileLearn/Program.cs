using System.IO;
using System.Text;

namespace FileLearn
{
    class Program
    {
        static void WriteText(string fileName)
        {
            File.WriteAllText(fileName, "hello word");
        }

        static void ReadText(string fileName)
        {
            System.Console.WriteLine(File.ReadAllText(fileName));

        }

        static void WriteFS(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes("encodujeme ascii a dostanu byty");
                fs.Write(buffer, 0, buffer.Length);
            }

            fs.Flush();
            fs.Close();
        }
        static void ReadFS(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            if (fs.CanRead)
            {
                byte[] buffer = new byte[1025];
                int readBuffer = fs.Read(buffer, 0, buffer.Length);

                System.Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, readBuffer));
            }


            fs.Flush();
            fs.Close();
        }
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\42073\Temp\shity.txt";
            WriteText(fileName);
            ReadText(fileName);

            string fileName2 = @"C:\Users\42073\Temp\shityFileStream";
            WriteFS(fileName2);
            ReadFS(fileName2);
            System.Console.ReadLine();
        }
    }
}
