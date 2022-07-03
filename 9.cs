using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _9
    {
        static void Main()
        {
            int i = 0;
            List<int> list = new List<int>();
            list.Add(55);
            list.Add(550);
            list.Add(33);
            list.Add(333);
            list.Add(10);
            list.Add(24);
            list.Add(443);
            list.Add(232);
            list.Add(23);
            list.Add(232);
            list.Add(343);
            list.Add(32);


            foreach(var item in list)
            {
                Console.WriteLine(item);

            }

           List<int> l = list.FindAll(x=>x>80?true:false);   
           Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            foreach(var nu in l)
            {
                Console.WriteLine(nu);
            }
            Console.ReadLine(); 
        }

        
        

       
    }
}
