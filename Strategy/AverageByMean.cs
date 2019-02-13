using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace com.quansheng.DesignPatterns
{
    public class AverageByMean : IAverage
    {
        public int Average(List<int> values)
        {
            return values.Sum() / values.Count;
        }
    }
}