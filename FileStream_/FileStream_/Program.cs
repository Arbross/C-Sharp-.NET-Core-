using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_
{
    static class FS
    {
        public static void WriteString(string str, string fname)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte len = (byte)bytes.Length; // simplier - on our view that the line has the length less than 255
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                fs.WriteByte(len); // write length of byte array(converted line)
                fs.Write(bytes);//, 0, bytes.Length);
            }
        }
        public static string ReadString(string fname)
        {
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                byte len = (byte)fs.ReadByte();
                byte[] bytes = new byte[len];
                fs.Read(bytes);
                return Encoding.UTF8.GetString(bytes);
            }
        }
        public static void WriteInt(int number, string fname)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                fs.Write(bytes);//, 0, bytes.Length);
            }
        }
        public static int ReadInt(string fname)
        {
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                byte[] bytes = new byte[sizeof(int)];
                fs.Read(bytes);
                return BitConverter.ToInt32(bytes);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string fname = "demo.dat";
            int value = 12345;
            FS.WriteInt(value, fname);
            Console.WriteLine($"Int32 : {FS.ReadInt(fname)}");
            string str = "Lallala";
            FS.WriteString(str, fname);
            Console.WriteLine($"String : {FS.ReadString(fname)}");

        }
    }
}
