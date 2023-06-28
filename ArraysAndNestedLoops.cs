using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Случайная матрица");
            Console.WriteLine();

            int quantityStrings = 0;
            int quantityColumns = 0;
            Console.Write("Введите количество строк в матрице: ");
            quantityStrings = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            quantityColumns = int.Parse(Console.ReadLine());            
            int[,] randomMatrix = new int[quantityStrings, quantityColumns];

            Random rand = new Random();

            int matrixSum = 0;

            Console.WriteLine();

            for (int i = 0; i < quantityStrings; i++)
            {
                for (int j = 0; j < quantityColumns; j++)
                {
                    randomMatrix[i, j] = rand.Next(10);
                    matrixSum = matrixSum + randomMatrix[i, j];
                    Console.Write($"{randomMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сумма элементов матрицы равна: " + matrixSum);

            Console.WriteLine();
            Console.ReadKey();

            /////////////////////////////////////

            Console.WriteLine("2. Сложение матриц");
            Console.WriteLine();

            Console.WriteLine("Матрица A:");
            Console.WriteLine();

            int[,] randomMatrix2 = new int[quantityStrings, quantityColumns];            

            for (int i2 = 0; i2 < quantityStrings; i2++)
            {
                for (int j2 = 0; j2 < quantityColumns; j2++)
                {
                    randomMatrix2 [i2, j2] = rand.Next(-10, -1);                    
                    Console.Write($"{randomMatrix2[i2, j2], 3} ");                    
                }
                Console.WriteLine();                
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Матрица B:");
            Console.WriteLine();

            int[,] randomMatrix3 = new int[quantityStrings, quantityColumns];

            for (int i3 = 0; i3 < quantityStrings; i3++)
            {
                for (int j3 = 0; j3 < quantityColumns; j3++)
                {
                    randomMatrix3[i3, j3] = rand.Next(1, 10);
                    Console.Write($"{randomMatrix3[i3, j3], 3} ");                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Результат сложения матриц A и B:");
            Console.WriteLine();

            int[,] randomMatrixSum = new int[quantityStrings, quantityColumns];

            for (int iSum = 0; iSum < quantityStrings; iSum++)
            {
                for (int jSum = 0; jSum < quantityColumns; jSum++)
                {
                    randomMatrixSum[iSum, jSum] = randomMatrix2[iSum, jSum] + randomMatrix3[iSum, jSum];                    
                    Console.Write($"{randomMatrixSum[iSum, jSum], 3} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
