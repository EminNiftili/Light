namespace Light.Data.Entity.Implementation
{
    public class InvoiceDetail : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public float Amount { get; set; }
        public int ProductBranchId { get; set; }
        public int InvoiceId { get; set; }
    }
}
