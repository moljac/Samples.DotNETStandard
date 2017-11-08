# define PCL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

#if NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2
using TypeCode = Core.TypeCode;
#else
using TypeCode = System.TypeCode;
#endif


namespace Core
{
    public partial class Type
    {
        #if NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2
		public static Core.TypeCode GetTypeCode(System.Type type)
        #else
        public static System.TypeCode GetTypeCode(System.Type type)
        #endif
		{
            #if NETFX_CORE || PCL || PORTABLE
			if (type == null)
			{
				return TypeCode.Empty;
			}

            #if NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2
            Core.TypeCode result;
            if (!System.Reflection.Extensions.TypeCodes.TryGetValue(type, out result))
            {
                result = TypeCode.Object;
            }

            return result;
            #else
            System.TypeCode result;
            if (!System.Reflection.Extensions.TypeCodes.TryGetValue(type, out result))
            {
                result = System.TypeCode.Object;
            }

            return result;
            #endif

            #else
            return Type.GetTypeCode(type);
            #endif
		}

	}
}
