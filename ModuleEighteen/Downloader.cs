namespace ModuleEighteen
{
    class Downloader : Command
    {
        public Downloader(Receiver receiver) : base(receiver)
        {
            this.receiver = receiver;
            CommandID = (int)AvailableCommands.download;
        }

        public override async Task Run()
        {
            await Console.Out.WriteLineAsync("Команда Downloader запущена!");
            await receiver.Operation(CommandID);
        }
    }
}