using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Services
{
  public interface IProducts
  {
    public Task<List<MProduct>> Get_Products();
    public Task<MProduct> Get_Product(int id);
    public Task<MProduct> Add_Product(MProductDTO product);
    public Task<MProduct> Update_Product(MProductDTO product, int id);
    public Task<MProduct> Delete_Product(int id);
  }
}
