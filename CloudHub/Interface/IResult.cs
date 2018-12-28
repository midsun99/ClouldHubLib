using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYDLib.CloudHub.Interface
{
    interface IResult<T> where T:class
    {
        bool success { get; set; }
        int errorCode { get; set; }
        string error { get; set; }
        T data { set; get; }
    }
}
