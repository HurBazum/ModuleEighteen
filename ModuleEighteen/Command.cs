namespace ModuleEighteen
{
    enum AvailableCommands
    {
        description,
        download
    }

    abstract class Command
    {
        public Receiver receiver;
        public int CommandID { get; protected set; }

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public abstract Task Run();
    }
}