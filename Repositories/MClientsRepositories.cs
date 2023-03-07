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

    public MClientsRepositories(ApplicationDBContext dBContext, IMapper mapper)
    {
      this.dBContext = dBContext;
      this.mapper = mapper;
    }

    public async Task<MClientDTO> AddClient(MClientDTO clientDTO)
    {
      // hacer una busqueda si el cliente ya existe con el dni
        var client = await dBContext.Clients.FirstOrDefaultAsync(cli => cli.DNI == clientDTO.DNI);
        if (client == null)
        {
          var clientNew = mapper.Map<MClient>(clientDTO);
          dBContext.Add(clientNew);
          await dBContext.SaveChangesAsync();
          return mapper.Map<MClientDTO>(clientNew);
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

    public async Task<MClientDTO> UpdateClient(MClientDTO client, int id)
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
      return mapper.Map<MClientDTO>(clientUpdate);
    }
  }
}