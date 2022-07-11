using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Lection_5_Library
{
    public class MatrixHelper
    {
        public static int[,] GanerateMatrix(int size1, int size2)
        {
            Random random = new Random();
            int[,] matrix = new int[size1, size2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }

            return matrix;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //1.Find the minimum element of an array.
        public static int FindMinElement(int[,] matrix)
        {
            int[] arrayOfIndexs = FindIndexMinElement(matrix);
            return matrix[arrayOfIndexs[0], arrayOfIndexs[1]];
        }

        //2.Find the maximum element of an array.
        public static int FindMaxElement(int[,] matrix)
        {
            int[] arrayOfIndexs = FindIndexMaxElement(matrix);
            return matrix[arrayOfIndexs[0], arrayOfIndexs[1]];
        }

        //3.Find the index of the minimum element of the array.
        public static int[] FindIndexMinElement(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            int indexIMinElement = 0;
            int indexJMinElement = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[indexIMinElement, indexJMinElement])
                    {
                        indexIMinElement = i;
                        indexJMinElement = j;
                    }
                }
            }

            return new int[] {indexIMinElement, indexJMinElement};
        }

        //4.Find the index of the maximum element of the array.
        public static int[] FindIndexMaxElement(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            int indexIMaxElement = 0;
            int indexJMaxElement = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[indexIMaxElement, indexJMaxElement])
                    {
                        indexIMaxElement = i;
                        indexJMaxElement = j;
                    }
                }
            }

            return new int[] {indexIMaxElement, indexJMaxElement};
        }

        //5.Find the number of array elements that are greater than all their neighbors at the same time.

        //6.Flip an array about its main diagonal.
    }
}