using System;

namespace com.quansheng.DesignPatterns.Adapter
{
    public class Adapter : IAdapter
    {
        private Adaptee _adaptee = new Adaptee();
        public void Request()
        {
            Console.WriteLine("Call adapter request");
            // Usually do some additional work before call specific interface
            _adaptee.SpecificRequest();
        } 
    }
}