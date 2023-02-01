using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : Controller
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public CartController(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<MCart>>> Get()
        {
            return await context.Cart.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] CartDTO cartDTO)
        {
            var cart = mapper.Map<MCart>(cartDTO);

            context.Add(cart);

            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
