namespace Light.Data.Entity.Implementation
{
    public class ProductBranch : BaseEntity
    {
        public decimal Price { get; set; }
        public float Amount { get; set; }
        public int BranchOneCId { get; set; }
        public int ProductOneCId { get; set; }

        public Branch Branch { get; set; }
        public Product Product { get; set; }
    }
}
