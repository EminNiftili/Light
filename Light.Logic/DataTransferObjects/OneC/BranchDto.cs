using Light.Core.AutoMapper;
using Light.Data.Entity.Implementation;
using Light.Logic.Enums;

namespace Light.Logic.DataTransferObjects.OneC
{
    public class BranchDto : IBidirectionalMap<Branch>
    {
        public string Name { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
