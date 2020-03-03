using Like.data;
using Like.Data;
using Like.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;
        private readonly int _repliedTo;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity = new Reply()
            {
                OwnerId = _userId,
                CommentRepliedTo = model.CommentReplied
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
