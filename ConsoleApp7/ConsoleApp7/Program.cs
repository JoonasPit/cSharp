using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            String userNum1;
            String userNum2;
            Console.WriteLine("Anna kaksi lukua: ");

            userNum1 = Console.ReadLine();
            userNum2 = Console.ReadLine();
            int dentNum1 = Convert.ToInt32(userNum1);
            int dentNum2 = Convert.ToInt32(userNum2);

            if(dentNum1 == dentNum2)
            {
                Console.WriteLine(dentNum1 + " on yhtä suuri kuin " + dentNum2);
            }
            else if (dentNum1 < dentNum2)
            {
                Console.WriteLine(dentNum1 + " on pienempi kuin " + dentNum2);
            }
            else if (dentNum1 > dentNum2)
            {
                Console.WriteLine(dentNum1 + " on suurempi kuin " + dentNum2);
            }
        }
    }
}
