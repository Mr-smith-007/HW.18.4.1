using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HW._18._4._1
{
    internal class DownloadVideo : Ireceiver
    {
        string _url;
        public DownloadVideo(string url)
        {
            _url = url;
        }
        public void Operation()
        {
            Console.WriteLine("Ввведите путь сохранения видеоролика");
            string path = Console.ReadLine();
            Console.WriteLine("Скачивание начато");
            var youtube = new YoutubeClient();
            youtube.Videos.DownloadAsync(_url, path);
        }
    }
}
