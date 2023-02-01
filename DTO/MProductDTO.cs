using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
    public class MProductDTO
    {

        [MaxLength(50)]
        public string NameProduct { get; set; } = "";
        [MaxLength(50)]
        public string CodeProduct { get; set; } = "";
        [MaxLength(50)]
        public string Brand { get; set; } = "";
        [MaxLength(50)]
        public string Description { get; set; } = "";
        public int Quantity { get; set; }
        public float P_Unitary { get; set; }
        [MaxLength(300)]
        public string Image_Product { get; set; } = "";
    }
}
