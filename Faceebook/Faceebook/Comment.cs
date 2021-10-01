using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook
{
   public class Comment
    {
        public string Text;
        public string CommentedDate;
        public User[] CommentedUser;

        public Comment(string text)
        {
            this.Text = text;
        }
    }
}
