using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class Validate
    {
        public static bool ValidLessThanLength(string value, int length)
        {
            return value.Length < length;
        }

        public static bool ValidNotEmpty(string value)
        {
            return !String.IsNullOrEmpty(value);
        }
    }
}
