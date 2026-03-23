namespace SubscriptionManagerApi.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}