using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace com.quansheng.DesignPatterns
{
    public class AverageByMedian : IAverage
    {
        public int Average(List<int> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            if (sortedValues.Count % 2 == 1)
            {
                return sortedValues[(sortedValues.Count - 1) / 2];
            }
            
            return (sortedValues[(sortedValues.Count / 2) - 1] +
                sortedValues[sortedValues.Count / 2]) / 2;
        }
    }
}
        