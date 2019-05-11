using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZLogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ZLog.ZLogHelper.WriteLog("D:/Logtest/log.txt", "haha", false);
            ZLog.ZLogHelper.WriteLog("D:/Logtest/log.txt", "haha1", true);
            ZLog.ZLogHelper.WriteLog("D:/Logtest/log.txt", "haha2", true);
            ZLog.ZLogHelper.WriteLog("D:/Logtest/log.txt", "haha3", true);
        }
    }
}
