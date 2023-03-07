using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.Models
{
  public class MAuth
  {
    [Key]
    public int IdAuth { get; set; }
    [MaxLength(50)]
    public string User { get; set; } = "";
    [MaxLength(50)]
    public string Email { get; set; } = "";
    [MaxLength(300)]
    public string Password { get; set; } = "";
  }
}
