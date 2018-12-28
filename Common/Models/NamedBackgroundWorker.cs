///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.Common.Models
///文件名称		：NamedBackgroundWorker
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 22:30:14
///=================================
///功能描述		：
///使用说明		：
///修改人		：midsun
///
///**********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYDLib.Common.Models
{
    public class NamedBackgroundWorker : BackgroundWorker
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        public NamedBackgroundWorker(string myName)
        {
            name = myName;
        }
    }
}
