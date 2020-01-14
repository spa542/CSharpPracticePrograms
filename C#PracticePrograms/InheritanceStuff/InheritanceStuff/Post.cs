using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceStuff
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Ryan Rosiak";
        }

        // Non-Default Constructor
        public Post(string title, bool pub, string username)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = username;
            this.IsPublic = pub;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool pub)
        {
            this.Title = title;
            this.IsPublic = pub;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }

    }
}
