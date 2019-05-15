using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] tuotteet = { { "MacBook Air", "920,90", "€" }, 
                { "Jolla", "349", "€" },
                {"Nokia","99,80","€"}};
            
            Console.WriteLine(tuotteet[0,0] + tuotteet[0,1]+ tuotteet[0,2]);
            Console.WriteLine(tuotteet[1,0] + tuotteet[1,1] + tuotteet[1,2]);
            Console.WriteLine(tuotteet[2,0] + tuotteet[2,1] + tuotteet[2,2]);

        }
    }
} 
