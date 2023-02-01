using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public CompanyController(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MCompany>>> GetCompany()
        {
            return await context.Company.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> PostCompany([FromBody] CompanyDTO companyDTO)
        {
            var company = mapper.Map<MCompany>(companyDTO);
            context.Add(company);
            await context.SaveChangesAsync();
            return Ok(company);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, [FromBody] CompanyDTO companyDTO)
        {
            var company = mapper.Map<MCompany>(companyDTO);
            company.IdCompany = id;
            context.Update(company);
            await context.SaveChangesAsync();
            return Ok(company);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await context.Company.FirstOrDefaultAsync(x => x.IdCompany == id);
            if (company == null)
            {
                return NotFound();
            }
            context.Remove(company);
            await context.SaveChangesAsync();
            return Ok(id);
        }
    }
}
