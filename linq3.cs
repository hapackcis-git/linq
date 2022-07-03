using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class linq3
    {
        static void Main(string[] args)
        {

            int[] num=new int[10] {1,2,3,4,5,6,7,8,9,0};
            
            var nquery =
                from int Number in num
                let sqrNo=Number*Number
                where sqrNo>0 
                select (Number,sqrNo);
            foreach(var a in nquery)
            {
                Console.Write(a);

            }
        }
    }
}
