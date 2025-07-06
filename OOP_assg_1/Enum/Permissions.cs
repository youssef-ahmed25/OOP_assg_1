using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assg_1.Enum
{
    [Flags]
    internal enum Permissions
    {
        Delete = 1,
        Execute = 2, 
        read=4, 
        write=8
    }
}
