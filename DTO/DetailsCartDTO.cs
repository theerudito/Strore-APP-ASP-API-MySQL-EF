using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
    public class DetailsCartDTO
    {
        public int IdCart { get; set; }

        public string Date_Now { get; set; } = "";

        public string Hour_Now { get; set; } = "";

        public float Subtotal { get; set; }

        public float Subtotal12 { get; set; }

        public float SubTotal0 { get; set; }
        public float IvaTotal { get; set; }
        public float Total { get; set; }
    }
}
