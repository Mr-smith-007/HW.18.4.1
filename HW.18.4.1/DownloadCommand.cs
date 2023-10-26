﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._18._4._1
{
    internal class DownloadCommand :Icommand
    {
        Ireceiver download;

        public DownloadCommand(Ireceiver download)
        {
            this.download = download;
        }

        public void Run()
        {
            Console.WriteLine("Скачивание начато");
            download.Operation();
            Console.WriteLine("Скачивание завершено");

        }
    }
}