using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceStuff
{
    class ImagePost: Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {
            // Nothing needed
        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;
            this.IsPublic = IsPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} -  {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
