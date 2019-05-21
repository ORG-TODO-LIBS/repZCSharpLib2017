using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
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
            var file = context.Request.Files["fileContent"];
            var count = context.Request.Files.Count;
            string ProjectID = context.Request["ProjectID"];
            string ModelID = context.Request["ModelID"];
            string UserName = context.Request["UserName"];
            string Phase = context.Request["Phase"];
            string updateTime = context.Request["updateTime"];

            JavaScriptSerializer jser = new JavaScriptSerializer();
            var str = jser.Serialize(new {
                count,
                ProjectID,
                ModelID,
                UserName,
                Phase,
                updateTime
            });

            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
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