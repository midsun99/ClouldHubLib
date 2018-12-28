///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.CloudHub.Models.Result
///文件名称		：QRResult
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 19:30:10
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
    public class QRResult
    {
        public bool success { get; set; }
        public QRResult_data data { get; set; }
    }
    public class QRResult_data
    {
        public string url { get; set; }
        public string token { get; set; }

    }
}
