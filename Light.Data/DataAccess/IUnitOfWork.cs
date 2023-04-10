using Light.Data.Repositories;
using Light.Data.Repositories.Implementation;

namespace Light.Data.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        IStoredProcedureRepository StoredProcedure { get; }
        IBonusLogRepository BonusLog { get; }
        IBranchRepository Branch { get; }
        ICashBoxRepository CashBox { get; }
        ICustomerRepository Customer { get; }
        IInvoiceDetailRepository InvoiceDetail { get; }
        IInvoiceRepository Invoice { get; }
        IProductBranchRepository ProductBranch { get; } 
        IProductRepository Product { get; }
    }
}
