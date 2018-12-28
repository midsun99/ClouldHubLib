///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.Common
///文件名称		：Untity
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 10:08:24
///=================================
///功能描述		：
///使用说明		：
///修改人		：midsun
///
///**********************************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LYDLib.Common
{
    public class Untity
    {
        /// <summary>
        /// 解析GZIP压缩
        /// </summary>
        /// <param name="st">数据流</param>
        /// <returns></returns>
        public static string DecompressGZIPStream(Stream st)
        {
            string re = "";
            int count = 0;
            try
            {
                using (GZipStream gzip = new GZipStream(st, CompressionMode.Decompress))
                {
                    do
                    {
                        byte[] buf = new byte[65535];
                        count = gzip.Read(buf, 0, 65535);
                        re += Encoding.UTF8.GetString(buf).Trim();

                    } while (count == 65535);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            return re.TrimEnd('\0');
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns>13位长整型时间戳</returns>
        public static long GetTimeStamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="dt">被转换的时间</param>
        /// <returns>13位长整型时间戳</returns>
        public static long GetTimeStamp(DateTime dt)
        {
            if (dt == null) return GetTimeStamp();
            return (dt.ToUniversalTime().Ticks - 621355968000000000) / 10000;
        }

        public static T ConvertToObject<T>(string jsonstr)
        {
            T re = JsonConvert.DeserializeObject<T>(jsonstr);
            return re;
        }

        public static Image ConvertToCircle(Image source,int width = 0, int height = 0 )
        { 
            if (width * height == 0)
            {
                width = source.Width;
                height = source.Height;
            }
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(source,width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if ((x - width/2) * (x - width/2) + (y - height/2) * (y - height/2) > width * height/4)
                    {
                        bitmap.SetPixel(x, y, System.Drawing.Color.FromArgb(0, 255, 255, 255));
                    }
                }
            }
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawImage(bitmap, new Point(width, height));
            g.DrawEllipse(new Pen(Color.LightGray),0, 0, width, height);
            g.Dispose();
            return bitmap;
        }

        /// <summary>
        /// 生成32位MD5字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetMD5String(object obj)
        {
            try
            {
                if (obj == null) throw new Exception("对象为空");
                StringBuilder strbul = new StringBuilder();
                BinaryFormatter formatter = new BinaryFormatter();
                byte[] objdata;
                using (MemoryStream ms = new MemoryStream())
                {
                    formatter.Serialize(ms, obj);
                    objdata = ms.GetBuffer();
                }
                if (objdata != null && objdata.Length > 32)
                {
                    MD5 m = MD5.Create();
                    byte[] md5data = m.ComputeHash(objdata);
                    for (int i = 0; i < md5data.Length; i++)
                    {
                        strbul.Append(md5data[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
                    }
                }
                return strbul.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Image DrawUnreadNum(int num,Size size)
        {
            Bitmap bp = new Bitmap(size.Width,size.Height);
            Graphics g = Graphics.FromImage(bp);
            
            g.FillEllipse(Brushes.Red, 0, 0, size.Width, size.Height);
            g.DrawString(num.ToString(), new Font(new FontFamily("宋体"), 12, FontStyle.Bold), Brushes.Wheat,(size.Width )/4.0f, (size.Height)/4.0f);
            g.Dispose();
            return bp;

        }
    }
}
