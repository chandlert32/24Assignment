using Like.Model;
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

    public class UserController : ApiController
    {
        /*
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
        {
            List<User> allUsers = await _context.Users.ToListAsync();
            return Ok(allUsers);
        }

        //DELETE BY ID
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteUserByEmail(string email)
        {
            User userEmail = await _context.Users.FindAsync(email);

            if (userEmail == null)
            {
                return NotFound();
            }

            _context.Users.Remove(userEmail);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();
        }
        */
    }
}

