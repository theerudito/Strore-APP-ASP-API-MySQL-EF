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
            builder.HasKey(e => e.IdProduct);
            builder.Property(e => e.NameProduct).IsRequired().HasMaxLength(100);
            builder.Property(e => e.CodeProduct).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Brand).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Description).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.P_Unitary).IsRequired();
            builder.Property(e => e.P_Total);
            builder.Property(e => e.Image_Product).IsRequired().HasMaxLength(300);
        }
    }
}
