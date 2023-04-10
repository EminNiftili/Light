namespace Light.Data.Entity.Implementation
{
    public class Invoice : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalVATPrice { get; set; }
        public string Barcode { get; set; }
        public int CustomerId { get; set; }
        public int CashBoxId { get; set; }
        public int PaymentMethod { get; set; }

        public Customer Customer { get; set; }  
        public CashBox CashBox { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
