using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class BonusLogConfig : BaseEntityConfig<BonusLog>
    {
        public override void Configure(EntityTypeBuilder<BonusLog> builder)
        {
            base.Configure(builder);

            builder.ToTable("BonusLog");
        }
    }
}
