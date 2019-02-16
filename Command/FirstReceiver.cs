using System;

namespace com.quansheng.DesignPatterns.Command
{
    public class FirstReceiver : IReceiver
    {
        public void ExecuteFirstCommand()
        {
            Console.WriteLine("Execute First command on First receiver");
        }

        public void ExecuteSecondCommand()
        {
            Console.WriteLine("Execute Second command on First receiver");
        }
    }    
}