using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZHttp
{
    /// <summary>
    /// http 帮助类
    /// </summary>
    public class ZHttpHelper
    {
        /// <summary>
        /// 发送 get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="statusCode">请求响应状态码</param>
        /// <returns>请求返回的数据</returns>
        public static string Get(string url, out string statusCode)
        {
            string result = string.Empty;

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                statusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
            }
            return result;
        }

        /// <summary>
        /// 发送 post 请求，在post中对应的 Content-Type 为：raw, Text。
        /// </summary>
        /// <param name="url">post地址</param>
        /// <param name="jsonstr">Text内容</param>
        /// <returns>请求返回的数据</returns>
        public static string Post_Text(string url, string jsonstr)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            //var postData = "thing1=hello";
            //postData += "&thing2=world";
            var data = Encoding.ASCII.GetBytes(jsonstr);
            request.Method = "POST";
            // request.ContentType = "application/x-www-form-urlencoded";
            request.ContentType = "text/plain";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            string msgPostRet;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    msgPostRet = sr.ReadToEnd();
                }
            }
            return msgPostRet;
        }

        /// <summary>
        /// 发送 post 请求，在post中对应的 Content-Type 为：raw, json。
        /// </summary>
        /// <param name="url">post地址</param>
        /// <param name="jsonstr">Text内容</param>
        /// <returns>请求返回的数据</returns>
        public static string Post_Json(string url, string jsonstr)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            //var postData = "thing1=hello";
            //postData += "&thing2=world";
            var data = Encoding.ASCII.GetBytes(jsonstr);
            request.Method = "POST";
            // request.ContentType = "application/x-www-form-urlencoded";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            string msgPostRet;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    msgPostRet = sr.ReadToEnd();
                }
            }
            return msgPostRet;
        }

        /// <summary>
        /// 发送 post 请求（不带文件），常用于form-data
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="datas">post的数据</param>
        /// <returns></returns>
        public static string Post(string url, Dictionary<string, string> datas)
        {
            using (var httpClient = new HttpClient())
            {
                // 请求头设置
                httpClient.DefaultRequestHeaders.Add("ContentType", "multipart/form-data");//设置请求头

                //post
                var urlobj = new Uri(url);
                var body = new FormUrlEncodedContent(datas);
                // response
                var response = httpClient.PostAsync(urlobj, body).Result;
                var data = response.Content.ReadAsStringAsync().Result;
                return data;//接口调用成功数据
            }
        }
    }
}
