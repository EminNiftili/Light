using Light.Data.DataAccess.Ef.EfRepositories;
using Light.Data.Repositories;
using Light.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public EfUnitOfWork()
        {
            _context = new ApiDbContext();

            _context.ChangeTracker.AutoDetectChangesEnabled = false;


            BonusLog = new BonusLogRepository(_context);
            Branch = new BranchRepository(_context);
            CashBox = new CashBoxRepository(_context);
            Customer = new CustomerRepository(_context);
            InvoiceDetail = new InvoiceDetailRepository(_context);
            Invoice = new InvoiceRepository(_context);
            ProductBranch = new ProductBranchRepository(_context);
            Product = new ProductRepository(_context);

            StoredProcedure = new StoredProcedureRepository(_context);
        }

        public IBonusLogRepository BonusLog { get; }
        public IBranchRepository Branch { get; }
        public ICashBoxRepository CashBox { get; }
        public ICustomerRepository Customer { get; }
        public IInvoiceDetailRepository InvoiceDetail { get; }
        public IInvoiceRepository Invoice { get; }
        public IProductBranchRepository ProductBranch { get; }
        public IProductRepository Product { get; }

        public IStoredProcedureRepository StoredProcedure { get; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            _context = null;
        }
    }
}
