using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook
{
    public class Post
    {
        public string Text;
        public string SharedDate;
        public int LikeCount;
        public int CommentCount;
        public Comment[] Comments;

        public Post(string text)
        {
            this.Text = text;
        }


    }
}
