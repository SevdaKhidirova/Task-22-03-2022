using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Comment
    {
        public string commentedDate;
        public string text;
       

        public Comment(string commentedDate,string text)
        {
            this.commentedDate = commentedDate;
            this.text = text;
        }
        public User Ucomment;


    }
}
