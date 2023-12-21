namespace HTMLGenerator.Domain.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SentRequest> SentRequests { get; set; }
    }
}
