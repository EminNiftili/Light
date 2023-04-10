using Light.Data.Entity.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace Light.Data.DataAccess.Ef.Configration
{
    public class BranchConfig : BaseEntityConfig<Branch>
    {
        public override void Configure(EntityTypeBuilder<Branch> builder)
        {
            base.Configure(builder);

            builder.ToTable("Branch");

            builder.HasMany(x => x.ProductBranches)
                .WithOne(x => x.Branch)
                .HasForeignKey(x => x.BranchOneCId)
                .HasPrincipalKey(x => x.OneCId);


            builder.HasMany(x => x.CashBoxes)
                .WithOne(x => x.Branch)
                .HasForeignKey(x => x.BranchId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
