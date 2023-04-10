using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class CustomerConfig : BaseEntityConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.ToTable("Customer");

            builder.HasMany(x => x.Invoices)
                .WithOne(x => x.Customer)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CustomerId);
        }
    }
}
