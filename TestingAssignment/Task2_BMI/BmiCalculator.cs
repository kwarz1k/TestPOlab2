using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Task2_BMI
{
    public static class BmiCalculator
    {
        public static double CalculateBmi(double weightKg, double heightM, int precision)
        {
            if (weightKg <= 0 || heightM <= 0 || precision < 0)
                throw new ArgumentException("Параметры должны быть строго больше нуля");

            double bmi = weightKg / (heightM * heightM);
            return Math.Round(bmi, precision);
        }
    }
}
