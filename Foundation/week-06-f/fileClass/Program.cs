using System;
using System.IO;

namespace fileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\myCv.doc";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg" , true );
            File.Delete(path);
            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path); // return string

            var infoPath = new FileInfo(path);
            infoPath.Delete();
            infoPath.CopyTo(".....");

            //Directory

            Directory.CreateDirectory(@"c:\temp\directory1");
            var file= Directory.GetFiles(@"c:\gpa", "*.*",SearchOption.AllDirectories);
            foreach (var item in file)
            {
                Console.WriteLine(item);
            }
            var directory = Directory.GetDirectories(@"c:\halouzkova", "*.*", SearchOption.AllDirectories);
            foreach (var item in directory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
