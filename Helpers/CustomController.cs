using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraECommerce.DataBase;

namespace ValkyraECommerce.Helpers
{
    public class CustomController : Controller
    {
        protected ShopDbContext _valkyraShopDbContext;

        public CustomController(ShopDbContext valkyraShopDbContext)
        {
            _valkyraShopDbContext = valkyraShopDbContext;
        }
    }
}
