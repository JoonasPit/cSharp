using System;


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputSum = 0;
            do
            {
                String suserNum1;
                String suserNum2;
                Console.Write("Anna luku: ");
                suserNum1 = Console.ReadLine();
                int userNum1 = Convert.ToInt16(suserNum1);
                inputSum = userNum1 + inputSum;
                Console.WriteLine(inputSum);

            } while (inputSum < 100);
            Console.WriteLine("Raja saavutettu.");
            }
    }
}
