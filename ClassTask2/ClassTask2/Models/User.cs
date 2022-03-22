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
        public string dateOfBirth;
        public bool isSingle;
        public string userName;

        public Post[] pUser;


        public User(string name,string surname,string email,string userName)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.userName = userName;

        }
        public User(string dateOfBirth,bool isSingle)
        {
            this.dateOfBirth = dateOfBirth;
            this.isSingle = isSingle;
        }
        public User()
        {

        }

    }
}
