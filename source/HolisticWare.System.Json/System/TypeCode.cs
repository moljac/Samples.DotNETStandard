#define UINVERSAL_WINDOWS_PLATFORM 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#if NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2
namespace Core
#else
namespace System
#endif
{
    #if !WINDOWS_UWP && ! NETSTANDARD1_3
    public enum TypeCode
    {
        Empty = 0,
        Object = 1,
        DBNull = 2,
        Boolean = 3,
        Char = 4,
        SByte = 5,
        Byte = 6,
        Int16 = 7,
        UInt16 = 8,
        Int32 = 9,
        UInt32 = 10,
        Int64 = 11,
        UInt64 = 12,
        Single = 13,
        Double = 14,
        Decimal = 15,
        DateTime = 16,
        String = 18,
    }
    #endif
}
