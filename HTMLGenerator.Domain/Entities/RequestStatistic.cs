namespace HTMLGenerator.Domain.Entities
{
    public class RequestStatistic
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int SentTimes { get; set; }
    }
}
