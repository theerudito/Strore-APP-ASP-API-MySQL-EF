using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Services
{
  public interface IClients
  {
    public Task<List<MClient>> GetClients();
    public Task<MClient> GetClient(int id);
    public Task<MClient> AddClient(MClientDTO client);
    public Task<MClient> UpdateClient(MClientDTO client, int id);
    public Task<MClient> DeleteClient(int id);
  }
}
