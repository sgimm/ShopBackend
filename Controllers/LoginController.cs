using Microsoft.AspNetCore.Mvc;
using System;
using ValkyraECommerce.DataBase;
using ValkyraECommerce.DatabaseDto.Shop;
using ValkyraECommerce.Helpers;
using ValkyraECommerce.Models;
using ValkyraECommerce.Services;

namespace ValkyraECommerce.Controllers
{
    [Route("api/Customers")]
    public class LoginController :Controller
    {
        private ILoginService _loginService = null;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("Login")]
        public IActionResult UserLogin([FromBody]WebLogin webLogin)
        {
            try
            {
                return Json(_loginService.Login(webLogin));
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }
    }
}