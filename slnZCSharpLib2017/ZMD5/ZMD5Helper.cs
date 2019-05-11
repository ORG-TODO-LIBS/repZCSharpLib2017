using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZMD5
{
    public class ZMD5Helper
    {
        /// <summary>
        /// 将指定字符串按指定编码进行 MD5 计算（32位小写）
        /// </summary>
        /// <param name="input">将进行 MD5 计算的字符串原文</param>
        /// <param name="encoding">指定的编码</param>
        /// <returns>计算后的32位小写MD5值</returns>
        public static string GetStringMD5(string input, Encoding encoding)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(encoding.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        /// <summary>
        /// 获取文件MD5值
        /// </summary>
        /// <param name="fileName">文件绝对路径</param>
        /// <returns>MD5值</returns>
        public static string GetFileMD5(string fileName)
        {
            MD5 md5 = MD5.Create();
            byte[] fileHashBytes;
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                fileHashBytes = md5.ComputeHash(file);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < fileHashBytes.Length; i++)
            {
                sb.Append(fileHashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
