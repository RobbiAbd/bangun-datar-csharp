using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Helpers
{
    internal static class MathUtils
    {
        public static int getFactorial(int number, int factor)
        {
            int result = number;
            if (factor > 0)
            {
                for (int i = 1; i < factor; i++)
                {
                    result *= number;
                }
            }

            return result;
        }
    }
}
