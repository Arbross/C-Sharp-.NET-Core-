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
        static void WriteInt(int number, string fname)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
        static int ReadInt(string fname)
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
                
        }
    }
}
