using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

namespace StripeAspNetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [HttpPost("create-checkout-session")]
        public IActionResult CreateCheckoutSession()
        {
            var options = new SessionCreateOptions
            {
                Mode = "payment",
                SuccessUrl = "http://localhost:5286/success.html",
                CancelUrl = "http://localhost:5286/cancel.html",
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Quantity = 1,
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = "usd",
                            UnitAmount = 1999,
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "My Product"
                            }
                        }
                    }
                }
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return Ok(new { url = session.Url });
        }
    }
}
