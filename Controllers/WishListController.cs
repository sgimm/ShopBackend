using Microsoft.AspNetCore.Mvc;
using ValkyraECommerce.DataBase;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Helpers;

namespace ValkyraECommerce.Controllers
{
    [Route("api")]
    public class WishListController : CustomController
    {
        public WishListController(ShopDbContext valkyraShopDbContext) : base(valkyraShopDbContext)
        {
        }

        [HttpGet("Customers/{customerId}/Wishlist")]
        public IActionResult GetWishList(string customerId)
        {
            return Ok();
        }

        [HttpPost("Customers/{customerId}/Wishlist")]
        public IActionResult PostWishListItem(string customerId, CustomerWishList wishList)
        {
            return Ok();
        }
    }
}