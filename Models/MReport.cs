using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.Models
{
    public class MReport
    {
        [Key]
        public int IdReport { get; set; }
        public int IdDetailCart { get; set; }
    }
}
