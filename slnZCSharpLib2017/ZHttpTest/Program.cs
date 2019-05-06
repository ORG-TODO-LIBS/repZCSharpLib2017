using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZHttpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string statusCode;
            string retdata = ZHttp.ZHttpHelper.Get("https://bimcomposer.probim.cn/api/prj/GetAllModels?ProjectID=c14075a2-6c91-1fdb-3fbe-76bf898c24cf", out statusCode);
            Console.WriteLine(statusCode);
            Console.ReadKey();
        }
    }
}
