using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentsSection.Models.Comments
{
    public class CommentRepository
    {
        private MyContext _myContext = new MyContext();

        public List<Comment> SelectComments()
        {
            return this._myContext.Comments.Where(comment => comment.Parent == 0).ToList();
        }

        public void Insert(Comment comment)
        {
            this._myContext.Comments.Add(comment);
            this._myContext.SaveChanges();
        }

        public List<Comment> SelectSubComments()
        {
            return this._myContext.Comments.Where(comment => comment.Parent > 0).ToList();
        }
    }
}
