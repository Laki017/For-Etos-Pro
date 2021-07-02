using System;

namespace GetParityNum_lib
{
    public static class ParytiNum
    {
        public static bool IsParytiNum(this int num) => (num & 1) == 0;

        public static bool IsParytiNumber(this int num) => num % 2 > 0 ? false : true;
    }
}
