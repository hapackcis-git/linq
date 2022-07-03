﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    //Write a program in C# to find the n-th maximum grade point achieved by the students from the list of students.


    public class Students
    {
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public int StuId { get; set; }
        public List<Students> GtStuRec()
        {
            List<Students>stulist=new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            return stulist;
        }
    }
    internal class _15
    {

        static void Main()
        {
            Students e =new Students();
            Console.Write("\nFind the nth Maximum Grade point achieved by the student");
            Console.Write("-----------------------------------");
            Console.Write("Which maximum grade point(1st,2nd,3rd,...) you want to find:  ");
            int grPointRank = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            var stulist = e.GtStuRec();
            var students=(from stuMast in stulist 
                          group stuMast by stuMast.GrPoint into g
                          orderby g.Key descending
                          select new
                          {
                              stuRecord=g.ToString()
                          }).ToList();
           

        }
    }
}
