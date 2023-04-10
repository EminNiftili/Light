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
        }
    }
}
