using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class BasketItem:BaseDbDto
    {
        public int CustomerBasketId { get; set; }
        public CustomerBasket CustomerBasket { get; set; }
        public ShopProduct Product { get; set; }
        public int Amount { get; set; }

    }
}
