using System.Collections.Generic;


namespace com.quansheng.DesignPatterns.Observer
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }  

        public void Remove(IObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var ob in this.observers)
            {
                ob.Update();
            }
        }
    }
}