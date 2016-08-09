using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal
{
    public static class IntExtensions
    {
        public static Int16 ToInt16(this string value)
        {
            return Convert.ToInt16(value);
        }

        public static Int32 ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static Int64 ToInt64(this string value)
        {
            return Convert.ToInt64(value);
        }
    }
}
