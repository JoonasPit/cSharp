using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInputNum1;
            String userInputNum2;


            Console.WriteLine("Anna kaksi lukua :");
            userInputNum1 = Console.ReadLine();
            userInputNum2 = Console.ReadLine();
            double doubledUserIn1 = Convert.ToDouble(userInputNum1);
            double doubledUserIn2 = Convert.ToDouble(userInputNum2);

            double numberAdd = doubledUserIn1 + doubledUserIn2;
            double subtract = doubledUserIn1 - doubledUserIn2;
            double numberTimes = doubledUserIn1 * doubledUserIn2;
            double numberDiv = doubledUserIn1 / doubledUserIn2;

            Console.WriteLine(doubledUserIn1 + "+" + doubledUserIn2 + "=" + numberAdd + 
                "\n" + doubledUserIn1 + "-" + doubledUserIn2 + "=" + subtract + 
                "\n" + doubledUserIn1 + "*" + doubledUserIn2 + "=" + numberTimes +
                "\n" + doubledUserIn1 + "/" + doubledUserIn2 + "=" +  numberDiv.ToString("F"));            
        }
    }
}
