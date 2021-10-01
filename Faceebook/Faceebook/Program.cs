using Facebook;
using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Kamran", "Mammadov", "14.04.2000", "kamranhm@code.edu.az", true );
            User user2 = new User("Ali", "Askerov", "21.05.1998", "ali.asker@pseudomail.com", false);
            
            Post post1 = new Post("Hello. How are you doing?");

            Comment comment1 = new Comment("I am fine. You?");

            Post[] posts = { post1 };
            Comment[] comments = { comment1 };
            User[] commentedUser = { user2 };

            user1.Posts = posts;



        }
    }
}
