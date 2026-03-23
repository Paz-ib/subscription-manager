using Microsoft.AspNetCore.Mvc;
using SubscriptionManagerApi.Models;

namespace SubscriptionManagerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        private static List<Subscription> subscriptions = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(subscriptions);
        }

        [HttpPost]
        public IActionResult Create(Subscription sub)
        {
            sub.Id = subscriptions.Count + 1;
            subscriptions.Add(sub);
            return Ok(sub);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Subscription updated)
        {
            var sub = subscriptions.FirstOrDefault(s => s.Id == id);
            if (sub == null) return NotFound();

            sub.Name = updated.Name;
            sub.Price = updated.Price;
            sub.StartDate = updated.StartDate;
            sub.PaymentMethod = updated.PaymentMethod;
            sub.IsActive = updated.IsActive;

            return Ok(sub);
        }

        // 💸 endpoint PRO
        [HttpGet("total")]
        public IActionResult GetTotal()
        {
            var total = subscriptions
                .Where(s => s.IsActive)
                .Sum(s => s.Price);

            return Ok(total);
        }
    }
}