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

            string postretdata = ZHttp.ZHttpHelper.Post_Text("http://112.35.1.155:1992/sms/norsubmit", @"eyJlY05hbWUiOiLkuK3lm73msLTliKnmsLTnlLXnrKzljYHkuInlt6XnqIvlsYDmnInpmZDlhazlj7giLCAiYXBJZCI6ImVkbSIsICJtb2JpbGVzIjoiMTM0Mzk0MjUzMDciLCAiY29udGVudCI6IjUwMjEwNSIsICJzaWduIjoiMTlNZm5FeHV0IiwgImFkZFNlcmlhbCI6IiIsICJtYWMiOiI3MjlmMDFjMGFlNGJiNWNjNTRhOGNiZTA1OGVjNDg2ZSJ9");

            Console.WriteLine(statusCode);
            Console.ReadKey();
        }
    }
}
