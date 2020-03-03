using Like.data;
using Like.Model;
using Like.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _24HrChallenge.Controllers
{
<<<<<<< HEAD
    [Authorize]
    public class NoteController : ApiController
    {
        public IHttpActionResult Get()
=======
    
    public class UserController : ApiController
<<<<<<< HEAD
    {
        /*
=======
    {/*
>>>>>>> master
        private readonly UserDbContext _context = new UserDbContext();

        //POST
        [HttpPost]
        public async Task<IHttpActionResult> UserSignUp (User user)
        {
            if (ModelState.IsValid && user != null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        //USERLOGIN
        public async Task<IHttpActionResult> UserLogIn()


        //GET ALL
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
>>>>>>> master
        {
            UserService userService = CreateUserService();
            return Ok(userService);
        }
        private UserService CreateUserService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new UserService(userId);
            return noteService;
        }
<<<<<<< HEAD
        */
    }
<<<<<<< HEAD

=======
=======
    */}
>>>>>>> master
>>>>>>> master
}


