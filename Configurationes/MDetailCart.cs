using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Configurationes
{
  public class MDetailCart : IEntityTypeConfiguration<MDetailsCart>
  {
    public void Configure(EntityTypeBuilder<MDetailsCart> builder)
    {
      builder.ToTable("DetailCart");
      builder.HasKey(x => x.IdDetailCart);
      builder.Property(x => x.IdCart).IsRequired();
      builder.Property(x => x.Date_Now).IsRequired();
      builder.Property(x => x.Hour_Now).IsRequired();
      builder.Property(x => x.Subtotal).IsRequired().HasColumnType("decimal(18,2)");
      builder.Property(x => x.Subtotal12).IsRequired().HasColumnType("decimal(18,2)");
      builder.Property(x => x.SubTotal0).IsRequired().HasColumnType("decimal(18,2)");
      builder.Property(x => x.IvaTotal).IsRequired().HasColumnType("decimal(18,2)");
      builder.Property(x => x.Total).IsRequired().HasColumnType("decimal(18,2)");
      builder.HasOne(x => x.Cart).WithMany(x => x.DetailsCart).HasForeignKey(x => x.IdCart);
    }
  }
}


