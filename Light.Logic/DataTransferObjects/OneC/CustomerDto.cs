using Light.Core.AutoMapper;
using Light.Data.Entity.Implementation;
using Light.Logic.Enums;

namespace Light.Logic.DataTransferObjects.OneC
{
    public class CustomerDto : IBidirectionalMap<Customer>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Barcode { get; set; }
        public decimal Bonus { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
