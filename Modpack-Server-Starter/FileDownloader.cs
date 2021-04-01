using System.Net;

namespace Modpack_Server_Starter
{
    public static class FileDownloader
    {
        public static void DownloadFile(string link)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(link, "modpack-download.zip");
            }
        }
    }
}