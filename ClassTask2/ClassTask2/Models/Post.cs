using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Post
    {
        public string text;
        public DateTime shareDate;
        public int likeCount;
        public int commentCount;

        public Comment[] comments;
        public Post()
        {
                
        }

        public Post(string text,DateTime shareDate)
        {
            this.text = text;
            this.shareDate = shareDate;
        }


    }
}
