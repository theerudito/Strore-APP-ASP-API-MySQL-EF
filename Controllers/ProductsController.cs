using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;
using Strore_APP_ASP_API_MySQL.Services;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class ProductsController : Controller
  {

    private readonly IProducts __repositoryProducts;

    public ProductsController(IProducts products)
    {
      __repositoryProducts = products;
    }

    [HttpGet]
    public async Task<ActionResult<List<MProduct>>> GetAllProducts()
    {
      return await __repositoryProducts.Get_Products();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<MProduct>> GetProduct(int id)
    {
      var product = await __repositoryProducts.Get_Product(id);
      if (product == null)
      {
        return BadRequest(new { message = "Product does not exist" });
      }
      return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult> AddProduct([FromBody] MProductDTO productDTO)
    {
      var newProduct = await __repositoryProducts.Add_Product(productDTO);
      if (newProduct == null)
      {
        return BadRequest(new { message = "Product already exists" });
      }
      return Ok(new { message = "Product added" });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateProduct([FromBody] MProductDTO productDTO, int id)
    {
      var updatedProduct = await __repositoryProducts.Update_Product(productDTO, id);
      if (updatedProduct == null)
      {
        return BadRequest(new { message = "Product does not exist" });
      }
      return Ok(new { message = "Product updated" });
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
      var deletedProduct = await __repositoryProducts.Delete_Product(id);
      if (deletedProduct == null)
      {
        return BadRequest(new { message = "Product does not exist" });
      }
      return Ok(new { message = "Product deleted" });
    }

  }
}
