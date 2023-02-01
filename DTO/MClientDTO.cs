using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
    public class MClientDTO
    {
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
    }
}
