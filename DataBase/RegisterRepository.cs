using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Dtos;

namespace ValkyraECommerce.DataBase
{
    public class RegisterRepository : RepositoryBase
    {
        public RegisterRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public bool CreateCustomerWebAccount(CustomerWebAccount customerWebAccount)
        {
            int result = 0;
            Customer customer = new Customer
            {
                Email = customerWebAccount.Email,
                Created = DateTime.Now
            };
            _dbContext.Add(customer);
            result += _dbContext.SaveChanges();

            customerWebAccount.Created = DateTime.Now;
            customerWebAccount.Password = StringToHash(customerWebAccount.Password);
            customerWebAccount.Customer = customer;
            _dbContext.WebAccounts.Add(customerWebAccount);
            result += _dbContext.SaveChanges();
            return result != 0 ? false : true;
        }
        public ValidationResult EmailExists(CustomerWebAccount customerWebAccount)
        {
            ValidationResult _validationResult = new ValidationResult();
            CustomerWebAccount _customerWebAccount = _dbContext.WebAccounts.FirstOrDefault(x => x.Email == customerWebAccount.Email);
            if(_customerWebAccount == null)
            {
                _validationResult.ResultCode = 0;
                _validationResult.ResultMessage = "Email Validation Erfolgreich";
            }
            else
            {
                _validationResult.ResultCode = 1;
                _validationResult.ResultMessage = "Email schon in Benutzung";
            }
            return _validationResult;
        }

        public EmailValidation CreateValidationLink(CustomerWebAccount customerWebAccount)
        {
            EmailValidation _emailValidation = new EmailValidation();
            _emailValidation.Created = DateTime.Now;
            _emailValidation.CustomerWebAccount = customerWebAccount;
            _emailValidation.ExpiredDate = DateTime.Now.AddDays(7);
            _emailValidation.ValidationId = Guid.NewGuid();
            _dbContext.EmailValidations.Add(_emailValidation);
            _dbContext.SaveChanges();
            return _emailValidation;
        }

        public CustomerWebAccount GetCustomerWebAccount(int id)
        {
            return _dbContext.WebAccounts.FirstOrDefault(wa => wa.Id == id);
        }

        public void UpdateCustomerWebAccount(CustomerWebAccount customerWebAccount)
        {
            customerWebAccount.Updated = DateTime.Now;
            _dbContext.WebAccounts.Update(customerWebAccount);
            _dbContext.SaveChanges();
        }

        public EmailValidation ValidationExist(string validationNumber)
        {
            return _dbContext.EmailValidations.FirstOrDefault(email=>email.ValidationId == Guid.Parse(validationNumber));
        }

        public CustomerWebAccount GetAccountForLogin(WebLogin webLogin)
        {
            return _dbContext.WebAccounts.Include("Customer").FirstOrDefault(x => x.Password == StringToHash(webLogin.Password) && x.Email == webLogin.Email);             
        }

        public CustomerWebToken CreateToken(CustomerWebAccount customerWebAccount)
        {
            CustomerWebToken customerWebToken = new CustomerWebToken() { Created = DateTime.Now, Expire = DateTime.Now, Updated = DateTime.Now, CustomerWebAccount = customerWebAccount };
            string _tempToken = new Guid().ToString() + ";" + customerWebAccount.Id;
            customerWebToken.Token = Convert.ToBase64String(Encoding.UTF8.GetBytes(_tempToken));
            _dbContext.CustomerWebTokens.Add(customerWebToken);
            _dbContext.SaveChanges();
            return customerWebToken;
        }

        private static string StringToHash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }       
    }
}
