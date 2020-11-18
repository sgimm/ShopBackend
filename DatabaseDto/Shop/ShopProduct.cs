namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class ShopProduct : BaseDbDto
    {
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Company { get; set; }
        public string Brand { get; set; }
        public string EAN { get; set; }
        public Price Price { get; set; }
        public ProcuctDescription ProcuctDescription { get; set; }
    }
}
