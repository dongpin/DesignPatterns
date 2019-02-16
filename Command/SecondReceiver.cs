using System;

namespace com.quansheng.DesignPatterns.Command
{
    public class SecondReceiver : IReceiver
    {
        public void ExecuteFirstCommand()
        {
            Console.WriteLine("Execute First command on Second receiver");
        }

        public void ExecuteSecondCommand()
        {
            Console.WriteLine("Execute Second command on Second receiver");
        }
    }    
}