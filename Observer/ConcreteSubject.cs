
namespace com.quansheng.DesignPatterns.Observer
{
    public class ConcreteSubject : Subject
    {
        private int state;
        public int State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
                this.Notify();
            }
        }
    }
}