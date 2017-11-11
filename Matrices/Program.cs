using System;
using TriangulationSysteme;
using InputOutputMatrice;

namespace Matrices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Probleme du cours de Ramadane
            double[,] A = { { 2, 3, -1 }, { 4, 4, -3 }, { -2, 3, -1 } };
            double[] B = { 1, 2, 3 };

            Console.WriteLine("La matrice avant changement: ");
            Output.OutputMatriceBi(A);

            double[,] U = ClassPivotGauss.TriangulaireSuperieur(A);

            Console.WriteLine("La matrice U apres changement: ");
            Output.OutputMatriceBi(U);

            double[,] L = ClassPivotGauss.TriangulaireInferieur(A);

            Console.WriteLine("La matrice L apres changement: ");
            Output.OutputMatriceBi(L);

            double[] Y = Operation.Descente(L, B);

            Console.WriteLine("La matrice Y : ");
            Output.OutputMatriceUni(Y);

            double[] X = Operation.Remonte(U, Y);

            Console.WriteLine("La matrice X : ");
            Output.OutputMatriceUni(X);
        }
    }
}
