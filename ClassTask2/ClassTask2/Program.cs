using ClassTask2.Models;
using System;

namespace ClassTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment();
            comment1.text = "privet";

            Comment comment2 = new Comment();
            comment2.text = "hello";

            Comment comment3 = new Comment();
            comment3.text = "holla";

            Post post1 = new Post();
            post1.text = "Hello to everyone";
            post1.likeCount = 1;
            post1.commentCount = 23;
            post1.comments =new Comment[]{ comment1,comment2};

            Post post2 = new Post();
            post2.text = "lol";
            post2.likeCount = 100;
            post2.commentCount = 1;

            post2.comments = new Comment[] { comment3 };

            User user = new User("Sevda", "Xidirova", "sevda@code.edu.az", "Sevda571");
            user.posts = new Post[] { post1, post2 };

            for(int i = 0; i < user.posts.Length; i++)
            {
                Console.WriteLine(user.posts[i].text);
                for(int j = 0; j < user.posts[i].comments.Length; j++)
                {
                    Console.WriteLine(user.posts[i].comments[j].text);
                }
            }

        }
    }
}
