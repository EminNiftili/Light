using Light.Logic.DataTransferObjects;

namespace Light.Logic.Services
{
    public interface ICashBoxService
    {
        FileInfoDto GetCashBoxDatabase(int cashBoxId);
        void RegisterCashBox();
    }
}
