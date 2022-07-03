using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    //Write a program in C# Sharp to count file extensions and group it using LINQ.
    internal class _17
    {
        static void Main()
        {
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };


            var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .GroupBy(z => z, (fExt, extCtr) => new
                {
                    Extension=fExt,
                    Count=extCtr.Count()

                });
            foreach (var m in fGrp)
                Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
            Console.ReadLine();
        }
    }
}
