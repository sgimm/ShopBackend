using Microsoft.EntityFrameworkCore;
using ValkyraECommerce.DatabaseDto.Shop;

namespace ValkyraECommerce.DataBase
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }
        public DbSet<CustomerWebAccount> WebAccounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<EmailValidation> EmailValidations { get; set; }
        public DbSet<CustomerWebToken> CustomerWebTokens { get; set; }
        public DbSet<CustomerWishList> CustomerWishLists { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<ShopUILanguageItem> ShopUILanguageItems { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }
        public DbSet<CustomerBasket> CustomerBaskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
