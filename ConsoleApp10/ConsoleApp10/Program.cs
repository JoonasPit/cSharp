using System;


namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int org = 1;
            Console.WriteLine(org);
            for (int i = 0; i < 20; i++)
            {
                
                Console.WriteLine(org);
                org += org;
            }
        }
    }
}
