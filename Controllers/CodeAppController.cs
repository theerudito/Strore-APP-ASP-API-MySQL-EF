using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeAppController : Controller
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public CodeAppController(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateCodeApp(MCodeApp codeApp)
        {
            context.CodeApp.Add(codeApp);
            context.SaveChanges();
            return Ok(codeApp);
        }

        [HttpGet("{id}")]
        public IActionResult GetCodeApp(int id)
        {
            var codeApp = context.CodeApp.Find(id);
            if (codeApp == null)
            {
                return NotFound("Code not found");
            }
            return Ok("Code found");
        }

    }
}
