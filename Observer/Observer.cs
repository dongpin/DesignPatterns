using System;

namespace com.quansheng.DesignPatterns.Observer
{
    public class Observer : IObserver
    {
        public int State {get; set;}

        public Observer(int value)
        {
            this.State = value;
        }

        public void Update()
        {
            this.State++;
            Console.WriteLine("State: {0}", this.State);
        }
    }
}