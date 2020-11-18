using System.ComponentModel.DataAnnotations;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public enum AddressTypes
    {
        Invoice,
        Delivery
    }
    public class CustomerAddress:BaseDbDto
    {
        [Required]
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string AddressInformation { get; set; }
        public Country Country { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}