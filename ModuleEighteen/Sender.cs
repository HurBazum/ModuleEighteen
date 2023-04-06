
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace ModuleEighteen
{
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public async Task Run()
        {
           await _command.Run();
        }
    }
}