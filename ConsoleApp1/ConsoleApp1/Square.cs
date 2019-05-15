using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 3 || j == 0 || j == 9)
                    {
                        Console.Write('*');

                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }

                Console.WriteLine();
            }

          
        }
    }
}
