using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            id = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
            ImageURL = imageURL;
        }
    }
}
