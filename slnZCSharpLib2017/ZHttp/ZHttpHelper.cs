using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
