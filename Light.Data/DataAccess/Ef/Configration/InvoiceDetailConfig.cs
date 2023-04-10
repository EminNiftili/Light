using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class InvoiceDetailConfig : BaseEntityConfig<InvoiceDetail>
    {
        public override void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            base.Configure(builder);
            builder.ToTable("InvoiceDetail");

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.InvoiceDetails)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.InvoiceId);

            builder.HasOne(x => x.ProductBranch)
                .WithOne()
                .HasPrincipalKey<ProductBranch>(x => x.Id)
                .HasForeignKey<InvoiceDetail>(x => x.ProductBranchId);
        }
    }
}
