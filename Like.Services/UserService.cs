using Like.data;
using Like.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.Services
{
    public class UserService
    {
        private readonly Guid _userId;

        public UserService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateUser(User user)
        {
            var entity =
                new User()
                {
                    Id = _userId,
                    Name = user.Name,
                    Email = user.Email,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
