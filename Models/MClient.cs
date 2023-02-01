using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.Models
{
    public class MClient
    {
        [Key]
        public int IdClient { get; set; }
        [MaxLength(50)]
        public string DNI { get; set; } = "";
        [MaxLength(50)]
        public string FirstName { get; set; } = "";
        [MaxLength(50)]
        public string LastName { get; set; } = "";
        [MaxLength(50)]
        public string Direction { get; set; } = "";
        [MaxLength(50)]
        public string Phone { get; set; } = "";
        [MaxLength(50)]
        public string Email { get; set; } = "";
        [MaxLength(50)]
        public string City { get; set; } = "";
        [MaxLength(100)]
        public DateTime created_at { get; set; }
        [MaxLength(100)]
        public DateTime updated_at { get; set; }
    }
}
