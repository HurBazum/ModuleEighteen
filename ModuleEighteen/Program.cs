using ModuleEighteen;

string videoQuery = string.Empty;

Console.Write("Введите ссылку на видео в YouTube: ");

videoQuery = Console.ReadLine()!;

try
{
    Receiver commandReceiver = new(videoQuery);

    Descriptor descriptCmd = new(commandReceiver);

    Downloader downloadCmd = new(commandReceiver);

    Sender senderCmd = new();

    senderCmd.SetCommand(descriptCmd);

    await senderCmd.Run();

    senderCmd.SetCommand(downloadCmd);
    
    await senderCmd.Run();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}