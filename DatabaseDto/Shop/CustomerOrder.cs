namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class CustomerOrder : BaseDbDto
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
