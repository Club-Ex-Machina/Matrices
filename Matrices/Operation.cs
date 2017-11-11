using System;

/**
    * Class Operation:
    *   Calcul la remonté et la descente
 */

namespace Matrices
{
    public class Operation
    {

        /**
        * 
        * Methode Descente: Calcul descente d'une matrice triangulaire inferieure
        *   
          @param double[,] tab : la matrice L triangulaire inferieure
          @param double[] sol : le vecteur solution de la matrice de depart
        * 
          @return double[] y : le vecteur solution resultant de la descente
        */
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

        /**
          * 
          * Methode Remonte: Remonte de la matrice U avec comme solution le vecteur Y resultant
          *                  de la descente de la matrice L
          *   
          * @param double[,] tab : la matrice U triangulaire superieur
            @param double[] sol : le vecteur solution resultant de la descente
          * 
            @return double[] x : le vecteur solution resultant de la descente et au final 
                                 le vecteur solution du systeme de depart
         */
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
