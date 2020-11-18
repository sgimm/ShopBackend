using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Dtos;

namespace ValkyraECommerce.Services
{
    public interface IRegistrationService
    {
        ValidationResult Register(CustomerWebAccount customerWebAccount);
        void Validate(string id);
    }
}
