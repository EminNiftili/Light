using Light.Data.Entity.Implementation;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class ProductBranchRepository : EfRepository<ProductBranch>, IProductBranchRepository
    {
        public ProductBranchRepository(DbContext context) : base(context)
        {
        }
    }
}
