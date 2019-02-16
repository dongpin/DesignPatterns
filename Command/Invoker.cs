namespace com.quansheng.DesignPatterns.Command
{
    public class Invoker
    {
        private Command _command;
        public Invoker(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            this._command.Execute();
        }
    }
}