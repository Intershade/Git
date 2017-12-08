using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Helpers
{
    public static class GetModifier
    {
        static GetModifier()
        {

        }

        public static bool State(int para1, string modif, int para2)
        {
            if (modif == ">")
            {
                if (para1 > para2)
                {
                    return true;
                }
            }
            if (modif == "<")
            {
                if (para1 < para2)
                {
                    return true;
                }
            }
            if (modif == ">=")
            {
                if (para1 >= para2)
                {
                    return true;
                }
            }
            if (modif == "<=")
            {
                if (para1 <= para2)
                {
                    return true;
                }
            }
            if (modif == "==")
            {
                if (para1 == para2)
                {
                    return true;
                }
            }
            if (modif == "!=")
            {
                if (para1 != para2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
