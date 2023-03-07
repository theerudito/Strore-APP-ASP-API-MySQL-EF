using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Configurationes
{
    public class MCartConfig : IEntityTypeConfiguration<MCart>
    {
        public void Configure(EntityTypeBuilder<MCart> builder)
        {
            builder.ToTable("Cart");
            builder.HasKey(x => x.IdCart);
            builder.Property(x => x.IdClient).IsRequired();
            builder.Property(x => x.IdProduct).IsRequired();
            builder.HasOne(x => x.Client).WithMany(x => x.Cart).HasForeignKey(x => x.IdClient);
            builder.HasOne(x => x.Product).WithMany(x => x.Cart).HasForeignKey(x => x.IdProduct);
        }
    }
}
