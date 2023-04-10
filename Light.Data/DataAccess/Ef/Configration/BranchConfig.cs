using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class BranchConfig : BaseEntityConfig<Branch>
    {
        public override void Configure(EntityTypeBuilder<Branch> builder)
        {
            base.Configure(builder);

            builder.ToTable("Branch");
        }
    }
}
