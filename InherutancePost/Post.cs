using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    class Post
    {
        private int currentPostId;

        protected int id { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }


        public Post()
        {
            id = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Someone";
        }


        public Post(string title, string sendByUsername, bool isPublic)
        {
            id = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}",id,Title,SendByUsername);
        }


    }
}
