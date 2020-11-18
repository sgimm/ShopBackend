using Microsoft.AspNetCore.Mvc;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Dtos;
using ValkyraECommerce.Models;
using ValkyraECommerce.Services;

namespace ValkyraECommerce.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomerRegisterController : Controller
    {
        private IRegistrationService _registrationService;

        public CustomerRegisterController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpGet("ValidationResult/{result}")]
        public IActionResult ValidationResult(string result)
        {
            CustomerRegisterLoginViewModel customerRegisterViewModel = new CustomerRegisterLoginViewModel
            {
                FunctionName = "ShowValidationResult",
                ValidationResultMessage = result
            };
            return View(customerRegisterViewModel);
        }

        // GET: api/CustomerRegister/5
        [HttpGet("Validation/{id}")]
        public IActionResult CustomerValidate(string id)
        {
            try
            { 
                _registrationService.Validate(id);
            }
            catch
            {
                return BadRequest();
            }
            return Redirect("/api/Customers/ValidationResult/ok");
        }

        // POST: api/CustomerRegister
        
        [HttpPost("Registration")]
        public ValidationResult Post([FromBody] CustomerWebAccount customerWebAccount)
        {
            return _registrationService.Register(customerWebAccount);
        }        
    }
}
