
using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
  public class AuthDTO
  {
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
  }
}