using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Videos;

namespace Module18PatternsAndAntipatterns
{
    class Receiver
    {
        private YoutubeClient youtubeClient = new YoutubeClient();
        public async Task GetInfo(string videoUrl)
        {
            var videoInfo = await youtubeClient.Videos.GetAsync(videoUrl);   
            Console.WriteLine($"Название: {videoInfo.Title}");
            Console.WriteLine($"Описание: {videoInfo.Description}");
        }
        public async Task DownloadVideo(string videoUrl)
        {
            try
            {
                await youtubeClient.Videos.DownloadAsync(videoUrl, @"C:\Users\Zver\Downloads\1.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast)).AsTask();
            }
            catch (VideoUnavailableException)
            {
                Console.WriteLine("Видео не доступно!");
            }
        }
    }
}
