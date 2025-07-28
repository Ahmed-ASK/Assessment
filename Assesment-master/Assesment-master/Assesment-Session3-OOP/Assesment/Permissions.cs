using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    [Flags]
    enum Permissions : byte
    {
        Read=1 , Write=2  , Delete = 4, Execute =8
    }
}
