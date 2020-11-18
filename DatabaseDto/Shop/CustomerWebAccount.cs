using System.ComponentModel.DataAnnotations;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class CustomerWebAccount:BaseDbDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Verified { get; set; }
        public Customer Customer { get; set; }
    }
}
