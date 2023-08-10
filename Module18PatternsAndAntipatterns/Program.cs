using YoutubeExplode;

namespace Module18PatternsAndAntipatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string videoUrl;
            var sender = new Sender();

            var receiver = new Receiver();
            Console.WriteLine("Введите адрес видео на Youtube:");
            videoUrl = Console.ReadLine();

            var getInfo = new GetInfo(receiver, videoUrl);
            sender.SetCommand(getInfo);
            sender.Run();
            Console.ReadLine();

            var downVideo = new DownloadVideo(receiver, videoUrl);
            sender.SetCommand(downVideo);
            sender.Run();

            


        }
    }
}