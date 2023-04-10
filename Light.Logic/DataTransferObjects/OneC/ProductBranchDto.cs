using Light.Core.AutoMapper;
using Light.Data.Entity.Implementation;
using Light.Logic.Enums;

namespace Light.Logic.DataTransferObjects.OneC
{
    public class ProductBranchDto : IBidirectionalMap<ProductBranch>
    {
        public decimal Price { get; set; }
        public float Amount { get; set; }
        public int BranchId { get; set; }
        public int ProductId { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
