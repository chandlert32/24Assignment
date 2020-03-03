using Like.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.Services
{
    class AppreciateService
    {

        private readonly Guid _userId;

        public AppreciateService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLike(Appreciate model)
        {

        }
    }
}
