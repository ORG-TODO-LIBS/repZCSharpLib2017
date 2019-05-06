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
            string srcStr = "1122";
            string md5edStr = ZMD5.ZMD5Helper.ToMD5(srcStr, Encoding.UTF8);
            Console.WriteLine(md5edStr);
            Console.ReadKey();
        }
    }
}
