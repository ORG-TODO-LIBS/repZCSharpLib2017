using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZLog
{
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public class ZLogHelper
    {
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="logpath">日志文件路径</param>
        /// <param name="content">日志内容（建议不要包含回车）</param>
        /// <param name="newline">是否另起一行</param>
        public static void WriteLog(string logpath, string content, bool newline)
        {
            string logDirPath = Path.GetDirectoryName(logpath);
            if(!Directory.Exists(logDirPath))
            {
                Directory.CreateDirectory(logDirPath);
            }
            using (StreamWriter sw = System.IO.File.AppendText(logpath))
            {
                if (newline)
                {
                    sw.Write("\r\n");
                }
                sw.Write(content);
                sw.Close();
            }
        }
    }
}
