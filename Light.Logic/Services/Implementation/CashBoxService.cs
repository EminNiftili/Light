using Light.Data.DataAccess;
using Light.Logic.DataTransferObjects;

namespace Light.Logic.Services.Implementation
{
    public class CashBoxService : ICashBoxService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CashBoxService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public FileInfoDto GetCashBoxDatabase(int cashBoxId)
        {
        }

        public void RegisterCashBox()
        {
            throw new NotImplementedException();
        }
    }
}
