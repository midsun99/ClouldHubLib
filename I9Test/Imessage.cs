using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I9Test
{
    interface Imessage
    {
        string headerUrl { get; set; }
        string fromUserName { get; set; }
        DateTime SendTime { get; set; }
        object Content { get; set; }
    }
}
