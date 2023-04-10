using System.Text.Json.Serialization;

namespace Light.Data.Entity.Implementation
{
    public class Branch : BaseEntity
    {
        public int OneCId { get; set; }
        public string Name { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }

        public ICollection<ProductBranch> ProductBranches { get; set; }
        public ICollection<CashBox> CashBoxes { get; set; }
    }
}
