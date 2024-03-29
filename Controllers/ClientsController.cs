﻿using Microsoft.AspNetCore.Mvc;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;
using Strore_APP_ASP_API_MySQL.Services;

namespace Strore_APP_ASP_API_MySQL.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class ClientsController : Controller
  {
    private readonly IClients _repositoryClients;

    public ClientsController(IClients clients)
    {
      _repositoryClients = clients;
    }
    [HttpGet]
    public async Task<ActionResult<List<MClient>>> GetAll()
    {
      var clients = await _repositoryClients.GetClients();
      return Ok(clients);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MClient>> GetClientById(int id)
    {
      var clients = await _repositoryClients.GetClient(id);
      if (clients == null)
      {
        return Ok(new { message = "Client not exist" });
      }
      return Ok(clients);
    }
    [HttpPost]
    public async Task<ActionResult> PostClient([FromBody] MClientDTO clientDTO)
    {
      var clientExist = await _repositoryClients.AddClient(clientDTO);
      if (clientExist == null)
      {
        return Ok(new { message = "Client already exist" });
      }
      return Ok(new { message = "Client added" });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutClient([FromBody] MClientDTO clientDTO, int id)
    {
      var clientExist = await _repositoryClients.UpdateClient(clientDTO, id);
      if (clientExist == null)
      {
        return Ok(new { message = "Client not exist" });
      }
      return Ok(new { message = "Client updated" });
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> RemoveClient(int id)
    {
      var clientExist = await _repositoryClients.DeleteClient(id);
      if (clientExist == null)
      {
        return Ok(new { message = "Client not exist" });
      }
      return Ok(new { message = "Client removed" });
    }
  }
}
