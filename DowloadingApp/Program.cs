using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DowloadingApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Uri uri = new Uri("https://www.thinkbroadband.com/assets/images/download-files/iconDownload-1GB.png");
            //string remoteUri = "http://ipv4.download.thinkbroadband.com/";
            string fileName = "1GB.zip"/*, myStringWebResource*/;
            //myStringWebResource = remoteUri + fileName;

            using (var client = new WebClient())
            {
                client.DownloadFile("https://www.thinkbroadband.com/assets/images/download-files/iconDownload-1GB.png", fileName);
            }


            //using (var client = new WebClient())
            //{
            //    client.DownloadFile("https://www.thinkbroadband.com/assets/images/download-files/iconDownload-1GB.png", "a.mpeg");
            //}
        }
    }
}
