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

            //string postretdata = ZHttp.ZHttpHelper.Post_Text("http://112.35.1.155:1992/sms/norsubmit", @"eyJlY05hbWUiOiLkuK3lm73msLTliKnmsLTnlLXnrKzljYHkuInlt6XnqIvlsYDmnInpmZDlhazlj7giLCAiYXBJZCI6ImVkbSIsICJtb2JpbGVzIjoiMTM0Mzk0MjUzMDciLCAiY29udGVudCI6IjUwMjEwNSIsICJzaWduIjoiMTlNZm5FeHV0IiwgImFkZFNlcmlhbCI6IiIsICJtYWMiOiI3MjlmMDFjMGFlNGJiNWNjNTRhOGNiZTA1OGVjNDg2ZSJ9");
            string postretdata = ZHttp.ZHttpHelper.Post_Json("https://www.probim.cn:8080/api/User/Home/RemoveToken",
                String.Format(@"
{{
  ""Token"": ""{0}""
}}
", "8A99A875C0D7ACEABA4F50BCB30D8EA6BE9ACB415A7EE958383B139EA6B17B50B129B891A7D0A189177F2062817E97EB3C0511ABFB97E04D9B3D9996255C6214254151B8DC8F89B6D4EC5C7454556F04"));

            //string getretdata = ZHttp.ZHttpHelper.Get("http://localhost:5045/Handlers/TestHandler1.ashx?A=22&B1=33", out statusCode);
            Dictionary<string, string> para = new Dictionary<string, string>();
            para.Add("A", "ab123");
            para.Add("B1", "ab345");
            string postResult = ZHttp.ZHttpHelper.Post("http://localhost:5045/Handlers/TestHandler1.ashx", para);

            Console.WriteLine(statusCode);
            Console.ReadKey();
        }
    }
}
