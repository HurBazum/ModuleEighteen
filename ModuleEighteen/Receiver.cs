using YoutubeExplode;
using YoutubeExplode.Converter;

namespace ModuleEighteen
{
    class Receiver
    {
        public string Link { get; private set; }
        public YoutubeClient Youtube { get; set; }
        public Receiver(string s)
        {
            Youtube = new();
            Link = s;
        }

        public void SetLink(string s) 
        {
            Link = s;
        }

        public async Task Operation(int cmdID)
        {
            var video = await Youtube.Videos.GetAsync(Link);

            switch (cmdID)
            {
                case 0:
                        await Console.Out.WriteLineAsync(video.Title);
                        await Console.Out.WriteLineAsync(video.Description);
                break;

                case 1:
                    var outputFilePath = @$"{Environment.CurrentDirectory}\{video.Title}.mp4";  

                    if (!File.Exists(outputFilePath))
                    {
                        await Youtube.Videos.DownloadAsync(Link, outputFilePath);
                        await Console.Out.WriteLineAsync("Скачивание завершенно!");
                    }
                    else
                    {
                        await Console.Out.WriteLineAsync("Это видео уже скачано!");
                        return;
                    }
                    break;
            }
        }
    }
}