using System;
using System.Collections.Generic;

namespace com.quansheng.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStrategyPattern();
        }

        public static void RunStrategyPattern()
        {
            var averageMethod = new AverageByMean();
            var values = new List<int>(){1, 2, 3};
            var result = Calculator.AverageFor(values, averageMethod);

            Console.WriteLine("Strategy Pattern Output: {0}", result);
        }
    }
}
