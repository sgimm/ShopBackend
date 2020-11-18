using Microsoft.AspNetCore.Mvc;
using ValkyraECommerce.DataBase;
using ValkyraECommerce.Helpers;

namespace ValkyraECommerce.Controllers
{
    [Route("api/Products")]
    public class ProductViewControllerController : CustomController
    {
        public ProductViewControllerController(ShopDbContext valkyraShopDbContext) : base(valkyraShopDbContext)
        {
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(string id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok();
        }

        [HttpGet("TopProducts")]
        public IActionResult TopProducts()
        {
            return Ok();
        }
    }
}