using Light.Data.Entity.Implementation;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class BranchRepository : EfRepository<Branch>, IBranchRepository
    {
        public BranchRepository(DbContext context) : base(context)
        {
        }
    }
}
