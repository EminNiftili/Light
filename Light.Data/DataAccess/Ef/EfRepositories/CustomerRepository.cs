using Light.Data.Entity.Implementation;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }
    }
}
