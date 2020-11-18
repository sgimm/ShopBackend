using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraECommerce.DataBase;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Dtos;
using ValkyraECommerce.Helpers;

namespace ValkyraECommerce.Services
{
    public class RegistrationService : IRegistrationService
    {
        RegisterRepository _valkyraRegisterRepository = null;
        public RegistrationService(ShopDbContext dbContext)
        {
            _valkyraRegisterRepository = new RegisterRepository(dbContext);
        }

        public ValidationResult Register(CustomerWebAccount customerWebAccount)
        {
            CustomerWebAccount _customerWebAccount = customerWebAccount;
            ValidationResult _validationResult = _valkyraRegisterRepository.EmailExists(customerWebAccount);
            if (_validationResult.ResultCode == 0)
            {
                _valkyraRegisterRepository.CreateCustomerWebAccount(_customerWebAccount);
                EmailValidation emailValidation = _valkyraRegisterRepository.CreateValidationLink(_customerWebAccount);
                SendMailHelper sendMailHelper = new SendMailHelper();
                sendMailHelper.SendMail(customerWebAccount, emailValidation);
            }
            return _validationResult;
        }

        public void Validate(string id)
        {
            if (!string.IsNullOrWhiteSpace(id) && id != "undefined")
            {
                EmailValidation emailValidation = _valkyraRegisterRepository.ValidationExist(id);
                if (emailValidation != null)
                {
                    CustomerWebAccount customerWebAccount = _valkyraRegisterRepository.GetCustomerWebAccount(emailValidation.CustomerWebAccountId);
                    customerWebAccount.Verified = true;
                    _valkyraRegisterRepository.UpdateCustomerWebAccount(customerWebAccount);
                    
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
