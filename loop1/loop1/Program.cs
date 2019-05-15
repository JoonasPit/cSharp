using System;

namespace loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //userinput
            String userIn;
            bool found = false;
            // Generate random number

            int randomnum = 45

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Anna luku:");
                userIn = Console.ReadLine();
                int conIn = Convert.ToUInt16(userIn);
                if (conIn == randomnum)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    found = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
            }
        }
    }
}
