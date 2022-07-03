using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class linq2
    {
        static void Main()
        {
            int[] n2 = new int[12] { 1, 2, 3, 4, 5, -4, -6, -7, 10, 12, 11, 13 };
            var nquery =
                from vrnum in n2
                where vrnum > 0
                where vrnum < 11
                select vrnum;
            foreach (var vrnum in nquery)
            {
                Console.Write(vrnum);
            }
        }

    }
}
