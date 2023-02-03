using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Configurationes
{
    public class MClientsConfig : IEntityTypeConfiguration<MClient>
    {
        public void Configure(EntityTypeBuilder<MClient> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(e => e.IdClient);
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.DNI).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Direction).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Phone).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);
            builder.Property(e => e.City).IsRequired().HasMaxLength(50);
        }
    }
}
