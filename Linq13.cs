using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Linq13
    {
        static void Main()
        {
            Console.Write("Find the uppercase words in a sting: ");
            Console.Write("\n----------------------\n");
            string strNew;
            Console.Write("Input the string: ");
            strNew =Console.ReadLine();

            var ucWord = WordFilt(strNew);
            Console.Write("\n The UPPER CASE words are :\n");
             foreach(string strRet in ucWord)
            {
                Console.WriteLine(strRet);  
            }

             Console.ReadLine();    
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            var ucWord=mystr.Split(' ')
                .Where(x=> String.Equals(x,x.ToUpper(),StringComparison.Ordinal));    
           return ucWord;   
        }
    }
}
