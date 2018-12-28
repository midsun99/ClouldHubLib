///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：Result
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 13:07:22
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

namespace LYDLib.CloudHub.Models.Result
{
    public class Result
    {
        public bool success { get; set; }

        public object data { get; set; }
    }
}
