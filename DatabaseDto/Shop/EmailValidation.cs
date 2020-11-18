using System;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class EmailValidation : BaseDbDto
    {
        public DateTime ExpiredDate { get; set; }
        public Guid ValidationId { get; set; }
        public int CustomerWebAccountId { get; set; }
        public CustomerWebAccount CustomerWebAccount {get; set;}
    }
}
