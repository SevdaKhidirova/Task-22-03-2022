using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Comment
    {
        public DateTime commentedDate;
        public string text;

        public Comment()
        {

        }
        public Comment(DateTime commentedDate,string text)
        {
            this.commentedDate = commentedDate;
            this.text = text;
        }
        public User commenter;

    }
}
