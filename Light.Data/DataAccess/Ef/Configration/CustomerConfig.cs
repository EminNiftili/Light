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
        }
    }
}
