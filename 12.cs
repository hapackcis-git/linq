using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class _12
    {
        static void Main()
        {
            int i = 0;
            List<int> list = new List<int>();   
            list.Add(33);
            list.Add(333);
            list.Add(3233);
            list.Add(23);
            list.Add(53);
            list.Add(43);
            list.Add(4343);
            list.Add(433);
            list.Add(553);
            list.Add(73);
            list.Add(63);
            list.Add(83);
            Console.WriteLine("\nThe member of the list are: ");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nEnter the number upto which you want to display sorted value: ");
            int n=Convert.ToInt32(Console.ReadLine());
            list.Sort();
            list.Reverse();
            Console.Write("The top {0} records from the list are: \n", n);
            foreach(int topn in list.Take(n))
            {
                Console.WriteLine(topn);
            }



        }
    }
}
