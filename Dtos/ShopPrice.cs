namespace ValkyraECommerce.Dtos
{
    public class ShopPrice
    {
        public int ShopPriceId { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
    }
}
