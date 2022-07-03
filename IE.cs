using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class IE
    {
      static void Main()
        {
            List<int> list = new List<int>() {111,222,333,333,555,666,777 };
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------");
            IEnumerator<int> nums = list.GetEnumerator(); 
            while(nums.MoveNext())
            {
                Console.WriteLine(nums.Current.ToString());    
            }
      
        }
    }
}
