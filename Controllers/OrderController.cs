using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValkyraECommerce.DataBase;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Helpers;

namespace ValkyraECommerce.Controllers
{
    [Route("api")]
    public class OrderController : CustomController
    {
        public OrderController(ShopDbContext valkyraShopDbContext) : base(valkyraShopDbContext)
        {
        }

        [HttpGet("Customers/{customerId}/Orders")]
        public IActionResult GetOrders(string customerId)
        {
            return null;
        }

        [HttpGet("Customers/{customerId}/Orders/{orderId}")]
        public IActionResult GetOrder(string customerId, string orderId)
        {
            return Ok();
        }

        [HttpPost("Customers/{customerId}/Order")]
        public IActionResult PostOrder(string customerId, [FromBody]CustomerOrder order)
        {
            return Json(order);
        }
    }
}