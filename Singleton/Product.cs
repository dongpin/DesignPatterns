using System;

namespace com.quansheng.DesignPatterns.Singleton
{
    public class Product
    {
        private static Object _lock = new Object();
        private static Product _instance;
        protected Product()
        {
            // Output message to show whenever the constructor being called
            Console.WriteLine("Create new Singleton instance!");
        }

        public static Product Instance()
        {
            if (_instance != null)
            {
                return _instance;
            }

            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Product();
                }
            }

            return _instance;
        }
    }
}