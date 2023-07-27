using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sqlpractice2Entities sqlentity = new sqlpractice2Entities();
            var res1 = from em in sqlentity.Employ5 select em;
            Console.WriteLine("Employ List : ");
            foreach( var e in res1 )
            {
                Console.WriteLine("Employ Id : "+e.empId);
                Console.WriteLine("Name : " + e.name);
            }
            Console.WriteLine("Enter EmpId : ");
            int empid = Convert.ToInt32(Console.ReadLine());
            var res2 = from em1 in sqlentity.Employ5 where em1.empId == @empid select em1;
            foreach( var e in res2 )
            {
                Console.WriteLine("Emp Id : " + e.empId);
                Console.WriteLine("Name : " + e.name);
                Console.WriteLine("Department : " + e.department);
                Console.WriteLine("Designation : " + e.designation);
                Console.WriteLine("Basic : " + e.basic);
            }
        }
    }
}
