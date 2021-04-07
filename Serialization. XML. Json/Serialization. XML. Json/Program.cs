using System;
using System.IO;

namespace Serialization._XML._Json
{
    // Directory and Directory Info
    // Process library
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"Path {path} not found");
                return;
            }
            Console.WriteLine($"Current path : {Directory.GetCurrentDirectory()}");
            Directory.SetCurrentDirectory(path);
            Directory.CreateDirectory("Demo");
            Directory.CreateDirectory("Demo/Text");

            File.WriteAllText("Demo/Text/test.txt", "Hello file");
            // Directory.Delete("Demo");
            Console.WriteLine($"Parent dir : {Directory.GetParent(".")}");

            Console.WriteLine();

            string[] dirs = Directory.GetDirectories(".");
            foreach (var item in dirs)
            {
                Console.WriteLine($"{Path.GetFileName(item), -10} {Directory.GetCreationTime(item)}");
            }

            Console.WriteLine();

            string[] files = Directory.GetDirectories(".");
            foreach (var f in files)
            {
                FileInfo fi = new FileInfo(f);
                Console.WriteLine($"{Path.GetFileName(f),-10} {File.GetCreationTime(f), -10} {fi.Length, -10}");
            }

            Console.WriteLine();

            string[] entries = Directory.GetFileSystemEntries(".");
            foreach (var f in entries)
            {
                string info;
                if (File.GetAttributes(f) != FileAttributes.Directory)
                {
                    FileInfo fi = new FileInfo(f);
                    info = $"{fi.Length, -10}";
                }
                else
                {
                    info = "<DIR>";
                }
                Console.WriteLine($"{info, -10} {Path.GetFileName(f),-10} {File.GetCreationTime(f),-10}");
            }

            Console.WriteLine();

            DirectoryInfo di = new DirectoryInfo("d:/");
            foreach (var d in di.GetFileSystemInfos())
            {
                Console.WriteLine($"{d.Name, -2} {/*d.Length*/d}");
            }
            
        }
    }
}
