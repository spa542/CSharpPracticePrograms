using System;

namespace Interfaces
{
    public interface INotifications
    {
        // Members
        void showNotification();
        string getDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        public Notification()
        {
            sender = "Admin";
            message = "Yo, what's up?";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void showNotification()
        {
            Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
        }

        public string getDate()
        {
            return date;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Ryan", "Tsup bro?", "12/16/19");
            Notification n2 = new Notification("Mary", "All good buddy", "12/16/19");
            n1.showNotification();
            n2.showNotification();
        }
    }
}
