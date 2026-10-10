using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Task3_Circle.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            Circle circle = new Circle(5, 0, 0);
            double expected = Math.PI * 25;

            double actual = circle.CalculateArea();

            // ВСТАВЛЯЕМ СЮДА ВЫВОД ПЛОЩАДИ:
            Console.WriteLine($"Результат работы метода (Площадь круга): {actual}");

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void ContainsPoint_PointInside_ReturnsTrue()
        {
            Circle circle = new Circle(5, 0, 0);

            bool actual = circle.ContainsPoint(3, 3);

            Console.WriteLine($"Результат работы метода (Точка 3,3 внутри круга): {actual}");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainsPoint_PointOutside_ReturnsFalse()
        {
            Circle circle = new Circle(5, 0, 0);

            bool actual = circle.ContainsPoint(6, 0);
            Console.WriteLine($"Результат работы метода (Точка 6,0 внутри круга): {actual}");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Constructor_InvalidRadius_ThrowsArgumentException()
        {
            try
            {
                new Circle(-1, 0, 0);
                Assert.Fail("Конструктор должен был выдать ошибку на отрицательный радиус");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"Результат работы метода (Поймано исключение): {ex.GetType().Name}");
            }
        }
    }
}
