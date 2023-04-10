using Light.Data.Entity.Implementation;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class InvoiceDetailRepository : EfRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(DbContext context) : base(context)
        {
        }
    }
}
