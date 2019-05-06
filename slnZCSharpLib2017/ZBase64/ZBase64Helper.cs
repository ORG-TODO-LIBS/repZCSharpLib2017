using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ZBase64
{
    public class ZBase64Helper
    {
        /// <summary>
        /// 将完成的 base64 字符串转为 Image 对象（Image对象在使用后记得dispose)
        /// </summary>
        /// <param name="JSBase64">以data:image/jpeg;base64...开头的字符串</param>
        /// <returns>需要进行Dispose的Image对象</returns>
        public static System.Drawing.Image Idispose_FromJSBase64(string JSBase64)
        {
            // 按逗号分隔，取出后面的，即C#可识别的部分
            string[] csBase64_ = JSBase64.Split(',');

            // 将C#可识别的部分的 base64 字符串转为 byte[]
            byte[] imageBytes = Convert.FromBase64String(csBase64_[1]);

            MemoryStream ms = new MemoryStream(imageBytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
    }
}
