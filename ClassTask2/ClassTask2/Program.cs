using ClassTask2.Models;
using System;

namespace ClassTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("","");
            



            Comment comment = new Comment("","");

            User user = new User("","","","");

            
             comment.Ucomment = user;

            
        }
    }
}
