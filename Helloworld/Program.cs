namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);*/
            int a,b;
            Console.WriteLine("Enter 1st number : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number : ");
            b=Convert.ToInt32(Console.ReadLine());
            int c=a+b;
            Console.WriteLine("sum :"+c);
        }
    }
}
