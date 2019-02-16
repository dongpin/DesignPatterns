using System;

namespace com.quansheng.DesignPatterns.Command
{
    public class FirstCommand : Command
    {
        public FirstCommand(IReceiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            base._receiver.ExecuteFirstCommand();
        }
    }
}