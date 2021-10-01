using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook
{
    public class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public string DateOfBirth;
        public bool IsSingle;
        public Post[] Posts;


        public User(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }

        public User(string name, string surname, string dateofbirth) : this(name, surname)
        {
            DateOfBirth = dateofbirth;
        }
        public User(string name, string surname, string dateofbirth, string email, bool isSingle) : this(name, surname, dateofbirth)
        {

            Email = email;
            IsSingle = isSingle;


        }



    }

}
