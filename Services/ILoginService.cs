using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Models;

namespace ValkyraECommerce.Services
{
    public interface ILoginService
    {
        CustomerRegisterLoginViewModel Login(WebLogin webLogin);
    }
}
