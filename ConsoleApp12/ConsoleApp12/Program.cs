using System;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            String limitGiven;
            Console.WriteLine("Anna yläraja:");
            limitGiven = Console.ReadLine();
            int limit = Convert.ToInt32(limitGiven);
            Console.WriteLine(2);
            for (int i = 3; i <= limit; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
