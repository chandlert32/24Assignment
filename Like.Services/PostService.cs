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
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userID)
        {
            _userId = userID;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    Title = model.Title,
                    Text = model.Text,
                    UserId = _userId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                ctx
                .Posts
                //.Where(e => e.UserId == _userId)
                .Select(
                e =>
                new PostItem
                {
                    //user = e.UserId,
                    Title = e.Title,
                    Name = e.User.Name
                    //CreatedUtc = e.CreatedUtc
                }
                );
                return query.ToArray();
            }
        }
    }
}
