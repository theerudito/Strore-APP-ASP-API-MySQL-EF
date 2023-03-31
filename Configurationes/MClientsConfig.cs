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
      builder.HasKey(c => c.IdClient);
      builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
      builder.Property(c => c.LastName).IsRequired().HasMaxLength(50);
      builder.Property(c => c.DNI).IsRequired().HasMaxLength(50);
      builder.Property(c => c.Direction).IsRequired().HasMaxLength(50);
      builder.Property(c => c.Phone).IsRequired().HasMaxLength(50);
      builder.Property(c => c.Email).IsRequired().HasMaxLength(50);
      builder.Property(c => c.City).IsRequired().HasMaxLength(50);
    }
  }
}
