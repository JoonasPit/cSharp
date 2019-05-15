using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tuoteHinta = new double[3];
            int[]tuoteLkm = new int[3];
            double[] tuoteYhtHinta = new double[3] ;

            tuoteHinta[0] = 7.96;
            tuoteHinta[1] = 72.00;
            tuoteHinta[2] = 99.90;

            tuoteLkm[0] = 1;
            tuoteLkm[1] = 2;
            tuoteLkm[2] = 3;

            Console.WriteLine("Tuote 1: " + tuoteHinta[0] + "\nTuote 2: "
                + tuoteHinta[1].ToString("0.0") + "\nTuote 3 :" + tuoteHinta[2].ToString("0.00"));
        }
    }
}
