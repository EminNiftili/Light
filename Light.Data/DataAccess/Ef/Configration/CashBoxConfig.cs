using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class CashBoxConfig : BaseEntityConfig<CashBox>
    {
        public override void Configure(EntityTypeBuilder<CashBox> builder)
        {
            base.Configure(builder);
            builder.ToTable("CashBox");
        }
    }
}
