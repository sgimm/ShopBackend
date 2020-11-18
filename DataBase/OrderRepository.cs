using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraECommerce.DataBase
{
    public class OrderRepository : RepositoryBase
    {
        public OrderRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
