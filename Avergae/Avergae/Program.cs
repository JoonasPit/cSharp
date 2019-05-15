using System;


namespace Avergae
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userGrades = new int[5];
            int totalSum = 0;
            double gpa;
            Console.WriteLine("Anna viisi kokonaislukua: ");
            for(int i = 0; i < 5; i++)
            {
                String asString;
                asString = Console.ReadLine();
                userGrades[i] = Convert.ToInt32(asString);
            }
            foreach (int grade in userGrades)
                totalSum = totalSum + grade;
            gpa = totalSum / 5;
            Console.WriteLine("Keskiarvo: " + gpa);
        }
    }
}
