using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class CodeAppController : Controller
  {
    private readonly ApplicationDBContext context;
    private readonly IMapper mapper;

    public CodeAppController(ApplicationDBContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<MCodeApp>>> GetCodeApp()
    {
      var codeApp = await context.CodeApp.ToListAsync();
      return codeApp;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCodeApp([FromBody] MCodeApp codeApp)
    {
      // buscar si existe el codigo no volver a crearlo
      var codeAppExists = await context.CodeApp.FirstOrDefaultAsync(cod => cod.CodeAdmin == codeApp.CodeAdmin);
      if (codeAppExists != null)
      {
        return BadRequest(new { message = "Code already exists" });
      }

      // encriptar el codigo
      var encriptar = BCrypt.Net.BCrypt.HashPassword(codeApp.CodeAdmin.ToString());

      context.CodeApp.Add(codeApp);
      context.SaveChanges();
      return Ok(new { message = "Code created" });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetCodeAppById(int id)
    {
      var codeApp = await context.CodeApp.FirstOrDefaultAsync(cod => cod.IdCode == id);
      if (codeApp == null)
      {
        return NotFound(new { message = "Code not found" });
      }
      return Ok(codeApp);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateCodeApp([FromBody] MCodeApp codeApp, int id)
    {
      var codeAppToUpdate = await context.CodeApp.FirstOrDefaultAsync(cod => cod.IdCode == id);
      if (codeAppToUpdate == null)
      {
        return NotFound(new { message = "Code not exists" });
      }
      codeAppToUpdate.CodeAdmin = codeApp.CodeAdmin;
      context.CodeApp.Update(codeAppToUpdate);
      context.SaveChanges();
      return Ok(new { message = "Code updated" });
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCodeApp(int id)
    {
      var codeAppToDelete = await context.CodeApp.FirstOrDefaultAsync(cod => cod.IdCode == id);
      if (codeAppToDelete == null)
      {
        return NotFound(new { message = "Code not exists" });
      }
      context.CodeApp.Remove(codeAppToDelete);
      context.SaveChanges();
      return Ok(new { message = "Code deleted" });
    }
  }
}
