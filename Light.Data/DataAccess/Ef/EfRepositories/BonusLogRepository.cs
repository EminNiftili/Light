using Light.Data.Entity.Implementation;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class BonusLogRepository : EfRepository<BonusLog>, IBonusLogRepository
    {
        public BonusLogRepository(DbContext context) : base(context)
        {
        }
    }
}
