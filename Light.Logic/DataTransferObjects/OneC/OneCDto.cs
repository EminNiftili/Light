namespace Light.Logic.DataTransferObjects.OneC
{
    public class OneCDto
    {
        public List<BranchDto> Branches { get; set; }
        public List<CustomerDto> Customers { get; set; } 
        public List<ProductBranchDto> ProductBranches { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
