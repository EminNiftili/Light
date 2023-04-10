using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class InvoiceConfig : BaseEntityConfig<Invoice>
    {
        public override void Configure(EntityTypeBuilder<Invoice> builder)
        {
            base.Configure(builder);
            builder.ToTable("Invoice");

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Invoices)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.CashBox)
                .WithMany(x => x.Invoices)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CashBoxId);

            builder.HasMany(x => x.InvoiceDetails)
                .WithOne(x => x.Invoice)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.InvoiceId);
        }
    }
}
