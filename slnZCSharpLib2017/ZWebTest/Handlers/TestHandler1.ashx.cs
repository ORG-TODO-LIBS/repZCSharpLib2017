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
            string a = context.Request.Form["A"];
            string b = context.Request.Form["B1"];

            ZAES z = new ZAES();
            string enced = z.EncryptByAES("0000", "abcabcabcabcabcabcabcabc");


            string originstr = z.DecryptByAES(enced, "abcabcabcabcabcabcabcabc");



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