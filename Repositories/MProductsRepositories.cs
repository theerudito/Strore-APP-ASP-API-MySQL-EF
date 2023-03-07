using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;
using Strore_APP_ASP_API_MySQL.Services;

namespace Strore_APP_ASP_API_MySQL.Repositories
{
  public class MProductsRepositories : IProducts
  {
    private readonly ApplicationDBContext _context;
    private readonly IMapper _mapper;
    public MProductsRepositories(ApplicationDBContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public async Task<MProduct> Add_Product(MProductDTO product)
    {
      // Check if product already exists con el code 
      var productExists = await _context.Products.FirstOrDefaultAsync(prod => prod.CodeProduct == product.CodeProduct);
      if (productExists == null)
      {
        var newProduct = _mapper.Map<MProduct>(product);
        await _context.Products.AddAsync(newProduct);
        await _context.SaveChangesAsync();
        return newProduct;
      }
      return null;
    }

    public async Task<MProduct> Delete_Product(int id)
    {
      var product = await _context.Products.FirstOrDefaultAsync(prod => prod.IdProduct == id);
      if (product != null)
      {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return product;
      }
      return null;
    }

    public async Task<MProduct> Get_Product(int id)
    {
      var product = await _context.Products.FirstOrDefaultAsync(prod => prod.IdProduct == id);
      if (product != null)
      {
        return product;
      }
      return null;
    }

    public async Task<List<MProduct>> Get_Products()
    {
      return await _context.Products.ToListAsync();
    }

    public async Task<MProduct> Update_Product(MProductDTO product, int id)
    {
      var productExists = await _context.Products.FirstOrDefaultAsync(prod => prod.IdProduct == id);
      if (productExists != null)
      {
        productExists.NameProduct = product.NameProduct;
        productExists.CodeProduct = product.CodeProduct;
        productExists.P_Unitary = product.P_Unitary;
        productExists.Quantity = product.Quantity;
        productExists.Description = product.Description;
        productExists.Image_Product = product.Image_Product;
        productExists.Brand = product.Brand;
        await _context.SaveChangesAsync();
        return productExists;
      }
      return null;
    }
  }
}