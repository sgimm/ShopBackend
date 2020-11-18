using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraECommerce.DataBase;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Models;

namespace ValkyraECommerce.Services
{
    public class LoginService : ILoginService
    {
        private RegisterRepository _valkyraRegisterRepository = null;
        public LoginService(ShopDbContext dbContext)
        {
            _valkyraRegisterRepository = new RegisterRepository(dbContext);
        }

        public CustomerRegisterLoginViewModel Login(WebLogin webLogin)
        {
            CustomerWebAccount customerWebAccount = _valkyraRegisterRepository.GetAccountForLogin(webLogin);
            CustomerRegisterLoginViewModel customerRegisterLoginViewModel = new CustomerRegisterLoginViewModel();
            customerRegisterLoginViewModel.FunctionName = "LoginResult";
            if (customerWebAccount == null)
            {
                customerRegisterLoginViewModel.ValidationResultMessage = "Username or password wrong!";
            }
            else
            {
                CustomerWebToken customerWebToken = _valkyraRegisterRepository.CreateToken(customerWebAccount);
                customerRegisterLoginViewModel.Token = customerWebToken.Token;
                customerRegisterLoginViewModel.Expire = customerWebToken.Expire;
                customerRegisterLoginViewModel.CustomerId = customerWebAccount.Customer.Id;
            }
            return customerRegisterLoginViewModel;
        }
    }
}
