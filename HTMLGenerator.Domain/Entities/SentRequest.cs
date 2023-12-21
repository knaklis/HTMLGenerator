namespace HTMLGenerator.Domain.Entities
{
    public class SentRequest
    {
        public int Id { get; set; }
        public DateTime SentDate { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
    }
}
