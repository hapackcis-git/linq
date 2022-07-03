using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _8
    {
        static void Main()
        {
            string chst, chen;
            char ch;
            string[] cities =
            {
               "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nInput starting character for the string: ");
            ch = (char)Console.Read();
            chst = ch.ToString();

                chen = ch.ToString();
            Console.Write("\nInput ending character for the string: ");
            ch=(char)Console.Read();
            chen=ch.ToString();

            var _Result=from x in cities
                        where x.StartsWith(chst)
                        where x.EndsWith(chen)
                        select x;
            Console.Write("\n\n");
            foreach(var city in _Result)
            {
                Console.Write(city,chen,chst);

            }
            Console.ReadLine(); 
        }

    }
}
