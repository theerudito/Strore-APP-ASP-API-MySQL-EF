using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
  public class MProductDTO
  {


    public string NameProduct { get; set; } = "";
    public string CodeProduct { get; set; } = "";
    public string Brand { get; set; } = "";
    public string Description { get; set; } = "";
    public int Quantity { get; set; }
    public decimal P_Unitary { get; set; }
    public string Image_Product { get; set; } = "";
  }
}
