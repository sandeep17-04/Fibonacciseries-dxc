using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class FibonacciSeries
    {
        public int[] Get(int n)
        {
            if (n <= 2)
                return new int[0];
            var series = new int[n];

            series[0] = 0;
            series[1] = 1;

            for (int i = 2; i < n; i++)
            {
                series[i] = series[i - 1] + series[i - 2];
            }
            return series;
        }
    }
}
