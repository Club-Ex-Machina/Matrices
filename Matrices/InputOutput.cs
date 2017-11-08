using System;

namespace InputOutputMatrice
{
    public class Input
    {
        public static void OutputMatrice(double[,] A)
        {
            int n = 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|" + A[i, 0] + "   " + A[i, 1] + "   " + A[i, 2] + "|");
            }
        }
    }
}
