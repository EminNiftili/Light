using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class ProductBranchConfig : BaseEntityConfig<ProductBranch>
    {
        public override void Configure(EntityTypeBuilder<ProductBranch> builder)
        {
            base.Configure(builder);
            builder.ToTable("ProductBranch");
        }
    }
}
