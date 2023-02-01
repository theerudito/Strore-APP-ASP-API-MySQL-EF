using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.Models
{
    public class MCodeApp
    {
        [Key]
        public int IdCode { get; set; }
        public int CodeAdmin { get; set; }
    }
}
