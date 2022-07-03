using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _6
    {
        static void Main()
        {
            string[] vs = new string[7] {"sun","mon","tue","wed","thu","fri","sat"};
           var  nquery=
                from weekday in vs
                select weekday; 
            foreach(var weekday in nquery)
            {
                Console.WriteLine(weekday);
            }
        }
    }
}
