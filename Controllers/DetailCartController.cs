using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetailCartController : Controller
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public DetailCartController(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MDetailsCart>>> Get()
        {
            return await context.DetailCart.ToListAsync();
        }


    }
}
