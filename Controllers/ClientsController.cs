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
    public class ClientsController : Controller
    {
        private readonly ApplicationDBContext dBContext;
        private readonly IMapper mapper;

        public ClientsController(ApplicationDBContext dBContext, IMapper mapper)
        {
            this.dBContext = dBContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MClient>>> GetAllClients()
        {
            return await dBContext.Clients.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MClient>> GetClientById(int id)
        {
            return await dBContext.Clients.FirstOrDefaultAsync(x => x.IdClient == id);
        }

        [HttpPost]
        public async Task<ActionResult> addClient([FromBody] MClientDTO clientDTO)
        {
            var newClient = mapper.Map<MClient>(clientDTO);

            dBContext.Add(newClient);

            await dBContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateClient(int id, [FromBody] MClientDTO clientDTO)
        {
            var client = await dBContext.Clients.FirstOrDefaultAsync(x => x.IdClient == id);

            if (client == null)
            {
                return NotFound();
            }

            client = mapper.Map(clientDTO, client);

            await dBContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteClient(int id)
        {
            var client = await dBContext.Clients.FirstOrDefaultAsync(x => x.IdClient == id);

            if (client == null)
            {
                return NotFound();
            }

            dBContext.Remove(client);

            await dBContext.SaveChangesAsync();

            return Ok();
        }
    }
}
