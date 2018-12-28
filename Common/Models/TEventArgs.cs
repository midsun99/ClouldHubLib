///**********************************************************************************
///
///=================================
///CLR版本		：4.0.30319.42000
///命名空间		：LYDLib.Common.Models
///文件名称		：TEventArgs
///=================================
///创建者		：midsun
///创建日期		：2018-12-17 10:16:44
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

namespace LYDLib.Common.Models
{
    public class TEventArgs<T> : EventArgs
    {
        public T Result { get; private set; }
        public TEventArgs(T obj)
        {
            this.Result = obj;
        }
    }
}
