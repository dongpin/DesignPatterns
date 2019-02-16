using System;

namespace com.quansheng.DesignPatterns.Command
{
    public class SecondCommand : Command
    {
        public SecondCommand(IReceiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            base._receiver.ExecuteSecondCommand();
        }
    }
}