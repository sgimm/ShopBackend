using System.Collections.Generic;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class CustomerWishList:BaseDbDto
    {
        public string Name { get; set; }
        public int CustomerWebAccountId { get; set; }
        public CustomerWebAccount CustomerWebAccount { get; set; }
        public List<WishListItem> WishListItems { get; set; }
    }
}
