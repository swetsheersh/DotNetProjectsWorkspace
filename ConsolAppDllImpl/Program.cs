using System;
using DllConsole;

namespace ConsolAppDllImpl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            Console.WriteLine("Sum is" + obj.sum(a,b));
            Console.WriteLine("sub is" + obj.sub(a,b));
            Console.WriteLine("Mul is" + obj.mul(a,b));

        }
    }
}
