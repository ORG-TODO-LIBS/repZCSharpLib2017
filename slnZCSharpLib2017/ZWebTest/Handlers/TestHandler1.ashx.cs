using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZEncrypt;

namespace ZWebTest.Handlers
{
    /// <summary>
    /// http://localhost:5045/Handlers/TestHandler1.ashx
    /// </summary>
    public class TestHandler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string a = context.Request["D1"];
            string b = context.Request["D2"];
            string c = context.Request["C3"];
            var file = context.Request.Files["F1"];

            //ZAES z = new ZAES();
            //string enced = z.EncryptByAES("0000", "abcabcabcabcabcabcabcabc");
            //string originstr = z.DecryptByAES(enced, "abcabcabcabcabcabcabcabc");

            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}