using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public AuthController(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] MAuth auth)
        {
            var userExists = await context.Auth.AnyAsync(x => x.Email == auth.Email);

            if (userExists)
            {
                return BadRequest("User already exists");
            }
            context.Auth.Add(auth);

            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] MAuth auth)
        {
            var user = await context.Auth.FirstOrDefaultAsync(x =>
            x.Email == auth.Email && x.Password == auth.Password);

            if (user == null)
            {
                return BadRequest("email or password is incorrect");
            }
            return Ok(user);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllUsers()
        {
            var auth = await context.Auth.ToListAsync();
            return Ok(auth);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdUser(int id)
        {
            var auth = await context.Auth.FirstOrDefaultAsync(x => x.IdAuth == id);
            return Ok(auth);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UPdateUser(int id, [FromBody] MAuth auth)
        {
            if (id != auth.IdAuth)
            {
                return BadRequest("Id not found");
            }
            context.Entry(auth).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var auth = await context.Auth.FirstOrDefaultAsync(x => x.IdAuth == id);
            if (auth == null)
            {
                return NotFound();
            }
            context.Auth.Remove(auth);
            await context.SaveChangesAsync();
            return Ok();
        }

    }

}