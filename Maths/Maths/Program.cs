using System;


namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int rollNum = 0;
            int prevNum = 1;

            for (int i = 0; i < 20; i++)
            {
                
                int prevSum = rollNum + prevNum;
                rollNum = prevNum;
                prevNum = prevSum;
                Console.WriteLine(rollNum);
            }
        }
    }
}
