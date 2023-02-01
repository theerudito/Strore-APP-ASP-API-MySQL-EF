using System.ComponentModel.DataAnnotations;

namespace Strore_APP_ASP_API_MySQL.DTO
{
    public class CompanyDTO
    {
        public string NameCompany { get; set; } = "";
        [MaxLength(50)]
        public string NameOwner { get; set; } = "";
        [MaxLength(50)]
        public string Direction { get; set; } = "";
        [MaxLength(50)]
        public string Email { get; set; } = "";
        [MaxLength(50)]
        public string RUC { get; set; } = "";
        [MaxLength(50)]
        public string Phone { get; set; } = "";
        public int NumDocument { get; set; }
        [MaxLength(50)]
        public string Serie1 { get; set; } = "";
        [MaxLength(50)]
        public string Serie2 { get; set; } = "";
        [MaxLength(50)]
        public string Document { get; set; } = "";
        [MaxLength(50)]
        public string DB { get; set; } = "";
        public float Iva { get; set; }
        [MaxLength(50)]
        public string Coin { get; set; } = "";

    }
}
