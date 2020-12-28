using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class FileEventArgs : EventArgs
    {
        public File File { get; set; }
    }

    class DownloadHelper
    {
        // Step 1 - create a delegate
        // public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        public event EventHandler<FileEventArgs> FileDownloaded; 

        // Step 2 - create an event based on that delegate

        // Step 3 - raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs() { File = file });
            }
        }
        public void Download(File file)
        {
            Console.WriteLine("Downloading file....");
            Thread.Sleep(4000);
            // Step 3.1
            OnFileDownloaded(file);
        }
    }
}
