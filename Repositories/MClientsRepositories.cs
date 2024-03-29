using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;
using Strore_APP_ASP_API_MySQL.Services;

namespace Strore_APP_ASP_API_MySQL.Repositories
{

  public class MClientsRepositories : IClients
  {

    private readonly ApplicationDBContext dBContext;
    private readonly IMapper mapper;
    private int IdClient = 1;


    public MClientsRepositories(ApplicationDBContext dBContext, IMapper mapper)
    {
      this.dBContext = dBContext;
      this.mapper = mapper;


    }

    public async Task AddConsumidorFinal()
    {
      var clientExist = await dBContext.Clients.FirstOrDefaultAsync(cli => cli.IdClient == IdClient);
      if (clientExist == null)
      {
        var newClient = new MClient();
        newClient.IdClient = IdClient;
        newClient.DNI = "9999999999";
        newClient.FirstName = "Consumidor";
        newClient.LastName = "Final";
        newClient.Direction = "Sin dirección";
        newClient.Phone = "9999999999";
        newClient.Email = "Sin email";
        newClient.City = "Sin ciudad";
        dBContext.Add(newClient);
        await dBContext.SaveChangesAsync();
      }
    }

    public async Task<MClient> AddClient(MClientDTO client)
    {
      // busco si existe el cliente con el dni si existe no lo agrego
      var clientExist = await dBContext.Clients.FirstOrDefaultAsync(cli => cli.DNI == client.DNI);
      if (clientExist == null)
      {
        var newClient = mapper.Map<MClient>(client);
        dBContext.Add(newClient);
        await dBContext.SaveChangesAsync();
        return newClient;
      }
      return null;
    }

    public async Task<MClient> DeleteClient(int id)
    {
      var client = await dBContext.Clients.FirstOrDefaultAsync(cli => cli.IdClient == id);
      if (client != null)
      {
        dBContext.Remove(client);
        await dBContext.SaveChangesAsync();
      }
      return client;
    }

    public async Task<MClient> GetClient(int id)
    {
      var client = await dBContext.Clients.FirstOrDefaultAsync(cli => cli.IdClient == id);
      if (client != null)
      {
        return client;
      }
      return null;
    }

    public async Task<List<MClient>> GetClients()
    {
      var clients = await dBContext.Clients.ToListAsync();
      return clients;
    }

    public async Task<MClient> UpdateClient(MClientDTO client, int id)
    {
      var clientUpdate = await dBContext.Clients.FirstOrDefaultAsync(cli => cli.IdClient == id);
      if (clientUpdate != null)
      {
        clientUpdate.DNI = client.DNI;
        clientUpdate.FirstName = client.FirstName;
        clientUpdate.LastName = client.LastName;
        clientUpdate.Direction = client.Direction;
        clientUpdate.Phone = client.Phone;
        clientUpdate.Email = client.Email;
        clientUpdate.City = client.City;
        await dBContext.SaveChangesAsync();
      }
      return mapper.Map<MClient>(clientUpdate);
    }
  }
}