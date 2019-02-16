using System.Collections.Generic;

namespace com.quansheng.DesignPatterns.Strategy
{
    public class Calculator
    {
        public static int AverageFor(List<int> values, IAverage averageAlgorithm)
        {
            return averageAlgorithm.Average(values);
        }    
    }
}