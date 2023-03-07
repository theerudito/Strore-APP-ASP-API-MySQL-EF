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
  public class ProductsController : Controller
  {
    private readonly ApplicationDBContext context;
    private readonly IMapper mapper;

    public ProductsController(ApplicationDBContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<MProduct>>> GetAllProducts()
    {
      return await context.Products.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<MProduct>> GetProduct(int id)
    {
      return await context.Products.FirstOrDefaultAsync(x => x.IdProduct == id);
    }

    [HttpPost]
    public async Task<ActionResult> addProduct([FromBody] MProductDTO productDTO)
    {
      var newProduct = mapper.Map<MProduct>(productDTO);

      context.Add(newProduct);

      await context.SaveChangesAsync();

      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> updateProduct([FromBody] MProductDTO productDTO)
    {
      var product = mapper.Map<MProduct>(productDTO);

      context.Entry(product).State = EntityState.Modified;

      await context.SaveChangesAsync();

      return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> deleteProduct(int id)
    {
      var product = await context.Products.FirstOrDefaultAsync(x => x.IdProduct == id);

      if (product == null)
      {
        return NotFound();
      }

      context.Remove(product);

      await context.SaveChangesAsync();

      return Ok();
    }

  }
}
