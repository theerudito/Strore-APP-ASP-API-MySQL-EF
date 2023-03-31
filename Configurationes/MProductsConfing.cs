using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.DB_Context
{
  public class MProductsConfing : IEntityTypeConfiguration<MProduct>
  {
    public void Configure(EntityTypeBuilder<MProduct> builder)
    {
      builder.ToTable("Products");
      builder.HasKey(p => p.IdProduct);
      builder.Property(p => p.NameProduct).IsRequired().HasMaxLength(100);
      builder.Property(p => p.CodeProduct).IsRequired().HasMaxLength(50);
      builder.Property(p => p.Brand).IsRequired().HasMaxLength(50);
      builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
      builder.Property(p => p.Quantity).IsRequired();
      builder.Property(p => p.P_Unitary).IsRequired();
      builder.Property(p => p.P_Total);
      builder.Property(p => p.Image_Product).IsRequired().HasMaxLength(300);
    }
  }
}
