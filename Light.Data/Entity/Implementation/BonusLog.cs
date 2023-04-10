namespace Light.Data.Entity.Implementation
{
    public class BonusLog : BaseEntity
    {
        public decimal Bonus { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }

        public Invoice Invoice { get; set; }
        public Customer Customer { get; set; }
    }
}
