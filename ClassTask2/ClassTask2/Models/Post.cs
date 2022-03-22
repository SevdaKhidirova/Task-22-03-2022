using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Post
    {
        public string text;
        public string shareDate;
        public int likeCount;
        public int commentCount;

        public Comment[] cPost;

        public Post(string text,string shareDate)
        {
            this.text = text;
            this.shareDate = shareDate;
        }


    }
}
