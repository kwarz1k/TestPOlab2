using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingAssignment.Task2_BMI;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestingAssignment.Task2_BMI.Tests
{
    [TestClass]
    public class BmiCalculatorTests
    {
        [TestMethod]
        public void CalculateBmi_StandardValues_ReturnsCorrectResult()
        {
            double weight = 70;
            double height = 1.75;
            int precision = 2;
            double expected = 22.86;

            double actual = BmiCalculator.CalculateBmi(weight, height, precision);
            Console.WriteLine($"Результат работы метода (ИМТ стандарт): {actual}");
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void CalculateBmi_PrecisionZero_ReturnsRoundedInt()
        {
            double weight = 70;
            double height = 1.75;
            int precision = 0;
            double expected = 23;

            double actual = BmiCalculator.CalculateBmi(weight, height, precision);
            Console.WriteLine($"Результат работы метода (ИМТ стандарт): {actual}");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateBmi_NegativeWeight_ThrowsArgumentException()
        {
            try
            {
                BmiCalculator.CalculateBmi(-70, 1.75, 2);
                Assert.Fail("Метод должен был выдать ошибку на отрицательный вес");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Результат работы метода (Поймано ожидаемое исключение): {ex.GetType().Name}");
            }
        }
    }
}
