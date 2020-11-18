using System.Collections.Generic;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class CustomerBasket : BaseDbDto
    {
        public CustomerWebAccount CustomerWebAccount { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public decimal TotalGrossAmount { get; set; }
    }
}
