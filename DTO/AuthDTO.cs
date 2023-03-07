
using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
  public class AuthDTO
  {
    public string Email { get; set; } = "";
    [MaxLength(300)]
    public string Password { get; set; } = "";
  }
}