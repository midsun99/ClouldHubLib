///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models
///文件名称		：Param
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 21:17:01
///=================================
///功能描述		：
///使用说明		：
///修改人		：midsun
///
///**********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYDLib.CloudHub.Models
{
    public class Param
    {
        public List<ParaBase> Paras { get; set; } = new List<ParaBase>();
        public byte[] GetData()
        {
            StringBuilder poststr = new StringBuilder();
            foreach (var item in this.Paras)
            {
                poststr.Append(item.Name);
                poststr.Append("=");
                if (item.Value != null)
                {
                    poststr.Append(item.Value.ToString());
                }
                else
                {
                    poststr.Append("");
                }
                poststr.Append("&");
            }
            String datastr = poststr.ToString().TrimEnd('&');
            byte[] postdata = Encoding.UTF8.GetBytes(datastr);
            return postdata;
        }
    }
    public class ParaBase
    {
        /// <summary>
        /// POST参数
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <param name="type">参数类型</param>
        /// <param name="value">参数值</param>
        public ParaBase(string name, Type type, object value)
        {
            this.Name = name;
            this.Type = type;
            this.Value = value;
        }
        public string Name { get; set; }
        public object Value { get; set; }
        public Type Type { get; set; }
    }

}
