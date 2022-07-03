using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] n1 = new int[10] {1,2,3,4,5,6,7,8,9,0 };
            var nquery=
               from varn in n1
             where (varn%2)==0
             select varn;
            foreach (int varn in nquery)
            {
                Console.Write("{0} ",varn);    
            }
            Console.Write("\n\n");
        }

    }
}
