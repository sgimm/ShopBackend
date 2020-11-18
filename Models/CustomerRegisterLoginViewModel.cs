using System;

namespace ValkyraECommerce.Models
{
    public class CustomerRegisterLoginViewModel
    {
        public int CustomerId { get; set; }
        public string FunctionName { get; set; }
        public string ValidationResultMessage {get;set;}
        public string Token { get; set; }
        public DateTime Expire { get; set; }
    }
}
