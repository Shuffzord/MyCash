namespace MyCashApi.Entities
{
    public class Transaction : BaseEntity
    {
        public int Value { get; set; }
        public string Category {get;set;}
    }
}