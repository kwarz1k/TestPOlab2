using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Task4_Matrix.Tests
{
    [TestClass]
    public class MyMatrixTests
    {
        [TestMethod]
        public void CalculateAverage_StandardMatrix_ReturnsCorrectAverage()
        {
            int[,] data = { { 1, 2 }, { 3, 4 } };
            MyMatrix matrix = new MyMatrix(data);

            double expected = 2.5;
            double actual = matrix.CalculateAverage();

            Console.WriteLine($"Результат работы метода (Среднее арифметическое матрицы): {actual}");

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void SortColumnsByMaxElementDescending_ValidMatrix_SortsCorrectly()
        {
            int[,] data = {
                { 1, 10 },
                { 5, 2 }
            };
            MyMatrix matrix = new MyMatrix(data);

            matrix.SortColumnsByMaxElementDescending();

            int[,] expected = {
                { 10, 1 },
                { 2, 5 }
            };

            StringBuilder matrixString = new StringBuilder();
            matrixString.AppendLine("Матрица после сортировки столбцов:");
            for (int r = 0; r < matrix.Rows; r++)
            {
                for (int c = 0; c < matrix.Cols; c++)
                {
                    matrixString.Append(matrix.Data[r, c] + " ");
                }
                matrixString.AppendLine();
            }
            Console.WriteLine(matrixString.ToString());

            CollectionAssert.AreEqual(expected, matrix.Data);
        }
    }
}
