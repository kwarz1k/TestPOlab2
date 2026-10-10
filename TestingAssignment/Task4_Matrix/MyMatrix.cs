using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Task4_Matrix
{
    public class MyMatrix
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public int[,] Data { get; private set; }

        public MyMatrix(int[,] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            Rows = data.GetLength(0);
            Cols = data.GetLength(1);
            Data = (int[,])data.Clone();
        }

        public double CalculateAverage()
        {
            if (Rows == 0 || Cols == 0) return 0;
            double sum = 0;
            foreach (var val in Data) sum += val;
            return sum / (Rows * Cols);
        }

        public void SortColumnsByMaxElementDescending()
        {
            var colsWithMax = Enumerable.Range(0, Cols)
                .Select(c => new
                {
                    ColIndex = c,
                    MaxVal = Enumerable.Range(0, Rows).Select(r => Data[r, c]).Max(),
                    Elements = Enumerable.Range(0, Rows).Select(r => Data[r, c]).ToArray()
                })
                .OrderByDescending(x => x.MaxVal)
                .ToList();

            for (int c = 0; c < Cols; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    Data[r, c] = colsWithMax[c].Elements[r];
                }
            }
        }
    }
}
