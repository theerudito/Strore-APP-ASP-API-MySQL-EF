using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
  public class DetailsCartDTO
  {
    public int IdCart { get; set; }
    public string Date_Now { get; set; } = "";
    public string Hour_Now { get; set; } = "";
    public decimal Subtotal { get; set; }
    public decimal Subtotal12 { get; set; }
    public decimal SubTotal0 { get; set; }
    public decimal IvaTotal { get; set; }
    public decimal Total { get; set; }
  }
}
