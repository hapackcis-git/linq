using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _10
    {
        static void Main()
        {
            int i = 0;
            int memlist, n, m;
            List<int> list = new List<int>();
            Console.Write("Input the number of members on the List: ");
            n=Convert.ToInt32(Console.ReadLine());
            for( i = 0; i < n; i++)
            {

                Console.Write("Member {0} :", i);
                memlist=Convert.ToInt32(Console.ReadLine());
               list.Add(memlist);   
            }
            Console.Write("\nInput the value above you want to display the members of the List: ");
            m=Convert.ToInt32(Console.ReadLine());  
            List<int> filter = list.FindAll(x=>x>m?true:false);
            Console.WriteLine("\nThe numbers greater than {0} are: ", m);
            foreach(var num in filter)
            {
                Console.WriteLine(num);
            }
            
            Console.ReadLine(); 
        }

    }
}
