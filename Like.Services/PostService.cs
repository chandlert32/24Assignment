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

        //public bool CreatePost(PostCreate model)
        //{
        //    var entity =
        //        new Post()
        //        {
        //            UserId = _userId,
        //            Title = model.Title,
        //            Text = model.Text,
        //            CreatedUtc = DateTimeOffset.Now
        //        };
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        ctx.Notes.Add(entity);
        //        return ctx.SaveChanges() == 1;
        //    }
        //}
    }
}
