using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); // publisher
            var unpackService = new UnpackService(); // receiver
            var notificationService = new NotificationService(); // receiver
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;

            downloadHelper.Download(file);
        }
    }

    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs args)
        {
            Console.WriteLine("UnpackerService: Unpacking the file... " + args.File.Title);
        }
    }
}
