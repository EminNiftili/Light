namespace Light.Data.Entity.Implementation
{
    public class Product : BaseEntity
    {
        public int OneCId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public decimal VAT { get; set; }
    }
}
