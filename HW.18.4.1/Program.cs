using HW._18._4._1.Commands;
using HW._18._4._1.Interfaces;
using HW._18._4._1.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace HW._18._4._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите url видеоролика");
            string url = Console.ReadLine();

                        
            User user = new User();
            Ireceiver getDescription = new GetDescription(url);
            user.SetCommand(new GetDescriptionCommand(getDescription));
            user.RunCommand();

            Ireceiver download = new DownloadVideo(url);
            user.SetCommand(new DownloadCommand(download));
            user.RunCommand();

            


        }
    }
}