using System;

namespace TriangulationSysteme
{
    public class ClassPivotGauss
    {
        public static double[,] TriangulaireSuperieur(double[,] tab)
        {
            int n = 3;
            double[,] A = new double [n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = tab[i, j];
                }
            }
            double temp;
            for (int i = 0; i < n - 1; i++)
            {
                temp = A[i, i];
                for (int j = i + 1; j < n; j++)
                {   
                    double temp1 = A[j, i];
                    for (int k = 0; k < n; k++)
                    {
                        A[j, k] = A[j, k] - A[i, k] * (temp1 / temp);
                    }
                }
            }
            return A;
        }
        public static double[,] TriangulaireInferieur(double[,] tab)
        {
            int n = 3;
            double[,] A = new double[n,n];

            double temp;
            for (int i = 0; i < n - 1; i++)
            {
                temp = tab[i, i];
                for (int j = i + 1; j < n; j++)
                {
                    double temp1 = tab[j, i];
                    for (int k = 0; k < n; k++)
                    {
                        tab[j, k] = tab[j, k] - tab[i, k] * (temp1 / temp);
                    }
                    A[j, i] = temp1 / temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                A[i, i] = 1;
            }
            return A;
        }
    }
}
