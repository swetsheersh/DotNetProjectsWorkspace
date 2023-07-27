using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Class1
    {
        public void show()
        {
            Console.WriteLine("It is first class");
        }
       
    }
    class Class2:Class1
    {
        public void display() 
        {
            Console.WriteLine("it is 2nd class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj=new Class2();
            obj.show();
            obj.display();
        }
    }
}
