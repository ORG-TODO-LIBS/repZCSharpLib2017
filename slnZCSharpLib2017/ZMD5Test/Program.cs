using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMD5Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcStr = "123";
            string md5edStr = ZMD5.ZMD5Helper.GetStringMD5(srcStr, Encoding.UTF8); // 202cb962ac59075b964b07152d234b70

            string filemd5 = ZMD5.ZMD5Helper.GetFileMD5("D:/md5test.txt");// 202cb962ac59075b964b07152d234b70

            Console.WriteLine(md5edStr);
            Console.ReadKey();
        }
    }
}
