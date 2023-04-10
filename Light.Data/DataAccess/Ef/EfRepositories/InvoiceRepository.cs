using Light.Data.Entity.Implementation;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class InvoiceRepository : EfRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbContext context) : base(context)
        {
        }
    }
}
