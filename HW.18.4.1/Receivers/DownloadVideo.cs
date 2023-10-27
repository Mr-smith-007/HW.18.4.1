using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW._18._4._1.Interfaces;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace HW._18._4._1.Receivers
{
    internal class DownloadVideo : Ireceiver
    {
        string _url;
        public DownloadVideo(string url)
        {
            _url = url;
        }
        public async Task Operation()
        {
            Console.WriteLine("Ввведите путь сохранения видеоролика");
            string path = Console.ReadLine();
            Console.WriteLine("Скачивание начато");

            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(_url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            if (streamInfo != null)
            {
                var fileName = $"{video.Title}.{streamInfo.Container}";
                var filePath = Path.Combine(path, fileName);

                await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath);
            }
        }
    }
}
