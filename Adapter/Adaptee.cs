using System;

namespace com.quansheng.DesignPatterns.Adapter
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Call specific request!");
        }
    }
}