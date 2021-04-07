using System;
using System.IO;

namespace BinaryWriter_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "demo.dat";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
            {
                bw.Write(1000);
                bw.Write("Text");
                bw.Write(true);
                bw.Write((int)ConsoleColor.Red);
            }
            using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
            {
                Console.WriteLine($"Int : {br.ReadInt32()}");
                Console.WriteLine($"String : {br.ReadString()}");
                Console.WriteLine($"Bool : {br.ReadBoolean()}");
                ConsoleColor color = (ConsoleColor)br.ReadInt32();
                Console.WriteLine($"Enum : {color}");
            }
        }
    }
}
