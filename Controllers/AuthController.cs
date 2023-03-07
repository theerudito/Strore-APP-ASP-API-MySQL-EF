using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class AuthController : Controller
  {
    private readonly ApplicationDBContext context;
    private readonly IMapper mapper;
    private readonly IConfiguration config;

    public AuthController(IConfiguration config, ApplicationDBContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
      this.config = config;
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register([FromBody] MAuth auth)
    {
      var userExists = await context.Auth.FirstOrDefaultAsync(user => user.Email == auth.Email);

      if (userExists != null)
      {
        return BadRequest(new { message = "User already exists" });
      }
      // encriptar password
      auth.Password = BCrypt.Net.BCrypt.HashPassword(auth.Password);
      context.Auth.Add(auth);
      await context.SaveChangesAsync();

      return Ok(new { message = "User created" });
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login([FromBody] AuthDTO auth)
    {
      var user = await context.Auth.FirstOrDefaultAsync(user => user.Email == auth.Email);
      //x.Email == auth.Email && x.Password == auth.Password);

      if (user == null)
      {
        return BadRequest(new { message = "User does not exist" });
      }

      // compare password
      if (!BCrypt.Net.BCrypt.Verify(auth.Password, user.Password))
      {
        return BadRequest(new { message = "Password or email is wrong" });
      }

      // generate token
      var tokenHandler = new JwtSecurityTokenHandler();

      var key = Encoding.ASCII.GetBytes(config["Jwt:Token"]);

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
        {
            new Claim(ClaimTypes.Name, user.User)
        }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      var token = tokenHandler.CreateToken(tokenDescriptor);


      return Ok(new { token = tokenHandler.WriteToken(token) });
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
      if (auth == null)
      {
        return BadRequest(new { message = "User does not exist" });
      }
      return Ok(auth);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<MAuth>> UpDateUser([FromBody] MAuth auth, int id)
    {
      var userExists = await context.Auth.FirstOrDefaultAsync(user => user.IdAuth == id);
      if (userExists != null)
      {
        userExists.User = auth.User;
        userExists.Password = BCrypt.Net.BCrypt.HashPassword(auth.Password);
        userExists.Email = auth.Email;
        await context.SaveChangesAsync();
        return Ok(new { message = "the user was successfully updated" });
      }
      return NotFound(new { message = "User does not exist" });
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteUser(int id)
    {
      var auth = await context.Auth.FirstOrDefaultAsync(x => x.IdAuth == id);
      if (auth == null)
      {
        return NotFound(new { message = "User does not exist" });
      }
      context.Auth.Remove(auth);
      await context.SaveChangesAsync();
      return Ok(new { message = "the user was successfully deleted" });
    }

  }

}