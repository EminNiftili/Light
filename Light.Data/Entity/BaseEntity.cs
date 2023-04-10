namespace Light.Data.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
