using System;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trth;

            String userIn;
            Console.WriteLine("Anna kokonaisluku: ");
            userIn = Console.ReadLine();
            int parIn = Convert.ToInt32(userIn);
            trth = parIn == 0 ? true : false;
            if (trth == true)
            {
                Console.WriteLine("Ei");
            }
            else
            {
                Console.WriteLine("Jaa");
            }

        }
    }
}
