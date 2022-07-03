using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _7
    {
        static void Main()
        {
            int[] num = new int[10] { 1, 2, 3, 7, 5, 5, 6, 7, 6, 7 };
            var nquery =
                from int number in num
                group number by number into y
                select y;
            foreach(var x in nquery)
            {
               
            }
        }
    }
}
