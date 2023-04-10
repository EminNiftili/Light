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

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.CashBoxes)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.BranchId);

            builder.HasMany(x => x.Invoices)
                .WithOne(x => x.CashBox)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CashBoxId);
        }
    }
}
