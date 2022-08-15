namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programming");
            Console.WriteLine("User Enter the Number");            
            Console.WriteLine("1: Reverse Number");
            Console.WriteLine("2: Stop watch");
            Console.WriteLine("3: Perfect Number");
            int Answer = Convert.ToInt32(Console.ReadLine());

            switch (Answer)
            {
                case 1:
                    ReverseNumber reverse = new ReverseNumber();
                    break;
                case 2:
                    StopWatch stopWatch = new StopWatch();
                    break;
                case 3:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    break;
                case 4:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    break;
                case 5:

            }

        }
    }
}