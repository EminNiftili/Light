namespace Light.Data.Entity.Implementation
{
    public class CashBox : BaseEntity
    {
        public string Name { get; set; }
        public int BranchId { get; set; }

        public Branch Branch { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
