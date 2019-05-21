using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZHttp;

namespace ZHttpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //            string statusCode;
            //            string retdata = ZHttp.ZHttpHelper.Get("https://bimcomposer.probim.cn/api/prj/GetAllModels?ProjectID=c14075a2-6c91-1fdb-3fbe-76bf898c24cf", out statusCode);

            //            //string postretdata = ZHttp.ZHttpHelper.Post_Text("http://112.35.1.155:1992/sms/norsubmit", @"eyJlY05hbWUiOiLkuK3lm73msLTliKnmsLTnlLXnrKzljYHkuInlt6XnqIvlsYDmnInpmZDlhazlj7giLCAiYXBJZCI6ImVkbSIsICJtb2JpbGVzIjoiMTM0Mzk0MjUzMDciLCAiY29udGVudCI6IjUwMjEwNSIsICJzaWduIjoiMTlNZm5FeHV0IiwgImFkZFNlcmlhbCI6IiIsICJtYWMiOiI3MjlmMDFjMGFlNGJiNWNjNTRhOGNiZTA1OGVjNDg2ZSJ9");
            //            string postretdata = ZHttp.ZHttpHelper.Post_Json("https://www.probim.cn:8080/api/User/Home/RemoveToken",
            //                String.Format(@"
            //{{
            //  ""Token"": ""{0}""
            //}}
            //", "8A99A875C0D7ACEABA4F50BCB30D8EA6BE9ACB415A7EE958383B139EA6B17B50B129B891A7D0A189177F2062817E97EB3C0511ABFB97E04D9B3D9996255C6214254151B8DC8F89B6D4EC5C7454556F04"));

            //            //string getretdata = ZHttp.ZHttpHelper.Get("http://localhost:5045/Handlers/TestHandler1.ashx?A=22&B1=33", out statusCode);
            //            Dictionary<string, string> para = new Dictionary<string, string>();
            //            para.Add("A", "ab123");
            //            para.Add("B1", "ab345");
            //            string postResult = ZHttp.ZHttpHelper.Post("http://localhost:5045/Handlers/TestHandler1.ashx", para);

            #region C# 带文件的请求
            string url = @"http://localhost:5045/Handlers/TestHandler1.ashx";
            //string url = "http://www.linkbim.com.cn:8009/api/prj/UploadModel";
            string modelId = "4f1e2e3d-6231-4b13-96a4-835e5af10394";
            string updateTime = "2016-11-03 14:17:25";
            string filePath = @"D:\总图路灯.pbc";
            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("modelId", modelId);
            datas.Add("updateTime", updateTime);
            Dictionary<string, string> filenameandval = new Dictionary<string, string>();
            filenameandval.Add("file1", filePath);
            filenameandval.Add("file2", filePath);
            string s1 = ZHttpHelper.Post_WithFile(url, datas, filenameandval);
            #endregion

            //Console.WriteLine(statusCode);
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
