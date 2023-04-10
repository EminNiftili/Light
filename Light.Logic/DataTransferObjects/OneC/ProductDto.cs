using Light.Core.AutoMapper;
using Light.Data.Entity.Implementation;
using Light.Logic.Enums;

namespace Light.Logic.DataTransferObjects.OneC
{
    public class ProductDto : IBidirectionalMap<Product>
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public decimal VAT { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
