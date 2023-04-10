namespace Light.Data.Entity.Implementation
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Barcode { get; set; }
        public decimal Bonus { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
