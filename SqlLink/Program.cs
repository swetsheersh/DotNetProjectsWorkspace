using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SqlLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employ> employList = new List<Employ>()
            {
                new Employ(25,"harsh","Sc","Isro",85000),
                new Employ(26,"harsh1","Sc","Isro",85000),
                new Employ(27,"harsh2","Sc","Isro",85000),
                new Employ(28,"harsh3","Sc","Isro",85000),
                new Employ(29,"harsh4","Sc","Isro",85000),
                new Employ(30,"harsh5","Sc","Isro",85000),

            };

            var result= from employ in employList select employ;
            Console.WriteLine("Result is : ");
            foreach( Employ employ in employList)
            {
                Console.WriteLine(employ.ToString() );
            }
        }
    }
}
