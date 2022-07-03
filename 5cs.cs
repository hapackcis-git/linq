using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _5cs
    {
        static void Main()
        {
            string str;
            Console.Write("Input the string: ");
            str=Console.ReadLine();
            var Freq= from x in str
                      group x by x into y
                      select y;
            foreach(var vv in Freq)
            {
                Console.Write(vv.Count());   
            }
        }
    }
}
