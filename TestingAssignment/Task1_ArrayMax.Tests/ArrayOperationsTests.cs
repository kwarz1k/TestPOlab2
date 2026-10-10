using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment.Task1_ArrayMax;

namespace TestingAssignment.Task1_ArrayMax.Tests
{
    [TestClass]
    public class ArrayOperationsTests
    {
        [TestMethod]
        public void FindMax_PositiveNumbers_ReturnsCorrectMax()
        {
            int[] array = { 1, 5, 3, 9, 2 };
            int expected = 9;
            int actual = ArrayOperations.FindMax(array);
            Console.WriteLine($"Результат работы метода (Максимум плюс): {actual}");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMax_NegativeNumbers_ReturnsCorrectMax()
        {
            int[] array = { -10, -5, -23, -2 };
            int expected = -2;
            int actual = ArrayOperations.FindMax(array);
            Console.WriteLine($"Результат работы метода (Максимум минус): {actual}");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMax_EmptyArray_ThrowsArgumentException()
        {
            int[] array = { };

            try
            {
                ArrayOperations.FindMax(array);
                Assert.Fail("Метод должен был выбросить исключение, но не сделал этого.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Результат работы метода (Поймано ожидаемое исключение): {ex.GetType().Name}");
            }
        }
    }
}
