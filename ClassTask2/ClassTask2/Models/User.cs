using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class User
    {
        public string name;
        public string surname;
        public string email;
        public DateTime dateOfBirth;
        public bool isSingle;
        public string userName;

        public Post[] posts;



        public User(string name,string surname,string email,string userName)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.userName = userName;

        }
        public User(DateTime dateOfBirth,bool isSingle)
        {
            this.dateOfBirth = dateOfBirth;
            this.isSingle = isSingle;
        }
        public User()
        {

        }

    }
}
