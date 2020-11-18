using System.Linq;
using ValkyraECommerce.DatabaseDto.Shop;

namespace ValkyraECommerce.DataBase
{
    public class BasketRepository : RepositoryBase
    {
        public BasketRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public void AddCustomerBasketItem(string customerId, BasketItem basketItem)
        {
            _dbContext.CustomerBaskets.FirstOrDefault(customerBasket => customerBasket.CustomerWebAccount.Id == int.Parse(customerId));  
            
        }
    }
}
