using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Task1_ArrayMax
{
    public static class ArrayOperations
    {
        public static int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не должен быть пустым");

            return array.Max();
        }
    }
}
