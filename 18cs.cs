using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    //Write a program in C# to calculate size of file using LINQ
    /*
     * LINQ stands for Language Integrated Query.Language Integrated means it is a part of language.
     * LINQ is developed by Microsoft and is available in System.Linq namespace
     * LINQ is uniform query syntax which can be applied on different data source
     * LINQ offers a compact,expenssive, and intelligible syntax for manipulating data
     * Using LINQ we can access any source of data using Linq
     * No need to learn new query for different data sources
     * Less code as compare to traditional approach
     * Compile time safety
     * IntelliSense support
     * Has lots of inbuilt method to support different operations.
     
    How lINQ works?
     *A LINQ provider is software that implements the IQueryProvider and IQueryable interfaces for  a particular data store.
     *In other words, it allows you to write LINQ queries against that data store.
     *Ways to write a Query
     *In LINQ there are three ways to write a query
     *1.Query syntax
     *2.Method syntax
     *Mixed Syntax(Query+Method)
     *Query Syntax:- This is one of the easy way to write complex query and readable format
     *The syntax for this type of query is like SQL query
     *Method syntax are most popular now a days.
     *In this approach query is written by using multiple methods and combining them with a dot(.);
     *Method syntas uses lambda expression to define any condition
     *
     *
     */

    internal class _18cs
    {
        static void Main(string[] Args)
        {
            List<int> list=new List<int>() { 1,2,3,4,5,56,6666,44,4,3,3,3,22};
            var querysyntax=
                from obj in list
                where obj>20
                select obj;
            foreach(var item in querysyntax)
            {
                Console.WriteLine(item);
            }
        }
    }

}
