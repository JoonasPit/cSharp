using System;


namespace Operators2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take two ints see remainder
            String userInput1;
            String userInput2;
            Console.WriteLine("Anna kaksi kokonaislukua: ");
            userInput1 = Console.ReadLine();

            userInput2 = Console.ReadLine();

            int newIn1 = Convert.ToInt32(userInput1);
            int newIn2 = Convert.ToInt32(userInput2);

            int remainder = newIn1 % newIn2;
            Console.WriteLine("Lukujen jakojäännös on: " + remainder);

        }
    }
}
