using System;

namespace Matrices
{
    public class Operation
    {
        public static double[] Descente(double[,] tab, double[] sol)
        {
            int n = 3;
            double x = 0;
            double[] y = new double[n];

            double[,] L = tab;

            y[0] = sol[0] / L[0, 0];

            for (int i = 1; i < n; i++)
            {
                x = 0;
                for (int j = 0; j < i; j++)
                {
                    x += L[i, j] * y[j];  
                }
                y[i] = (sol[i] - x ) / L[i, i]; 
            }

            return y;
        }

        public static double[] Remonte(double[,] tab, double[] sol)
        {

            int n = 3;
            double y = 0;
            double[] x = new double[n];

            double[,] U = tab;

            x[n - 1] = sol[n - 1]/U[n-1,n-1];

            for (int i = n - 2; i >= 0; i--)
            {
                y = 0;
                for (int j = i + 1; j < n; j++)
                {
                    y += U[i, j] * x[j]; 
                }
                x[i] = (sol[i] - y) / U[i,i];
            }

            return x;
        }
    }
}
