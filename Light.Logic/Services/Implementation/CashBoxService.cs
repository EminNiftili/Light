using Light.Data.DataAccess;
using Light.Data.Entity.Implementation;
using Light.Logic.DataTransferObjects;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

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
            var cashBox = _unitOfWork.GetRepository<CashBox>()
                .Queryable()
                .FirstOrDefault(x => x.Id == cashBoxId);



            return null;
        }

        public void RegisterCashBox()
        {
            throw new NotImplementedException();
        }
    }
}
