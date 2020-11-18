using Microsoft.AspNetCore.Mvc;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Services;

namespace ValkyraECommerce.Controllers
{
    [Route("api")]
    public class BasketController : Controller
    {
        private IBasketService _basketService = null;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet("Customers/{customerId}/Basket")]
        public IActionResult GetBasket(string customerId)
        {
            return Ok();
        }

        [HttpPost("Customers/{customerId}/Basket")]
        public IActionResult PostBasket(string customerId, [FromBody] BasketItem basketItem)
        {
            return Ok();
        }
    }
}