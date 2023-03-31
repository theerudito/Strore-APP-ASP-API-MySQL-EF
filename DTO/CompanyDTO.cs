using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
  public class CompanyDTO
  {
    public string NameCompany { get; set; } = "";
    public string NameOwner { get; set; } = "";
    public string Direction { get; set; } = "";
    public string Email { get; set; } = "";
    public string RUC { get; set; } = "";
    public string Phone { get; set; } = "";
    public int NumDocument { get; set; }
    public string Serie1 { get; set; } = "";
    public string Serie2 { get; set; } = "";
    public string Document { get; set; } = "";
    public string DB { get; set; } = "";
    public float Iva { get; set; }
    public string Coin { get; set; } = "";

  }
}
