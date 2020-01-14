using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs args)
        {
            Console.WriteLine("Notifying user that download is done...");
        }
    }
}
