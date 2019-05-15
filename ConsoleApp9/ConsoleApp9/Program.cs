using System;


namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            String userGrade;
            bool trth;
            Console.WriteLine("Anna arvosana: ");
            userGrade = Console.ReadLine();
            int convUser = Convert.ToInt32(userGrade);

            trth = convUser > 4 ? true : false;
            if (trth == true)
            {
                Console.WriteLine(convUser + " Opiskelija pääsee luokalta!");
            }
            else
            {
                Console.WriteLine(convUser + "Opiskelija jää luokalle");
            }

        }
    }
}
