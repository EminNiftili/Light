using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class ProductConfig : BaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.ToTable("Product");
        }
    }
}
