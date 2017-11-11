using System;

namespace InputOutputMatrice
{
    public class Output
    {
        public static void OutputMatriceBi(double[,] A)
        {
            int n = 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|" + A[i, 0] + "   " + A[i, 1] + "   " + A[i, 2] + "|");
            }
        }
        public static void OutputMatriceUni(double[] A)
        {

            Console.WriteLine("|" + A[0] + "   " + A[1] + "   " + A[2] + "|");
        }
    }
}
