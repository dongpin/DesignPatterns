using System.Collections.Generic;

namespace com.quansheng.DesignPatterns
{
    public class Calculator
    {
        public static int AverageFor(List<int> values, IAverage averageAlgorithm)
        {
            return averageAlgorithm.Average(values);
        }    
    }
}