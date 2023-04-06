namespace ModuleEighteen
{
    class Descriptor : Command
    {
        public Descriptor(Receiver receiver) : base(receiver)
        {
            this.receiver = receiver;
            CommandID = (int)AvailableCommands.description;
        }

        public override async Task Run()
        {
            await Console.Out.WriteLineAsync("Команда Descriptor запущена!\n");
            await receiver.Operation(CommandID);
        }
    }
}