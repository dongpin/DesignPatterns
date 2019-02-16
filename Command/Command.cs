namespace com.quansheng.DesignPatterns.Command
{
    public abstract class Command
    {
        protected IReceiver _receiver;
        public Command(IReceiver receiver)
        {
            this._receiver = receiver;
        }

        public abstract void Execute();
    }
}