using Light.Logic.DataTransferObjects.OneC;

namespace Light.Logic.Services
{
    public interface IOneCService
    {
        void OneCDataGenerate(OneCDto oneC, bool forceUpdate = false);
    }
}
