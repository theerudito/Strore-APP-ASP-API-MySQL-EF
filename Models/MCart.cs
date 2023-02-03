using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.Models
{
    public class MCart
    {
        [Key]
        public int IdCart { get; set; }
        public float P_Total { get; set; }
        public int IdClient { get; set; }
        public int IdProduct { get; set; }
        public MClient Client { get; set; } = null!;
        public MProduct Product { get; set; } = null!;
        public List<MDetailsCart> DetailsCart { get; set; } = new List<MDetailsCart>();
    }
}
