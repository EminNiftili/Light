using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class InvoiceConfig : BaseEntityConfig<Invoice>
    {
        public override void Configure(EntityTypeBuilder<Invoice> builder)
        {
            base.Configure(builder);
            builder.ToTable("Invoice");
        }
    }
}
