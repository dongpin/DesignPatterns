using System;

namespace com.quansheng.DesignPatterns.Singleton
{
    public class Product
    {
        private static Product _instance;
        protected Product()
        {
            // Output message to show whenever the constructor being called
            Console.WriteLine("Create new Singleton instance!");
        }

        public static Product Instance()
        {
            _instance = _instance ?? new Product();
            return _instance;
        }
    }
}