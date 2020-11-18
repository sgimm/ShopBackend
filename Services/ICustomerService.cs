using ValkyraECommerce.DatabaseDto.Shop;

public interface ICustomerService
{
    Customer GetCustomers(int id);
    void UpdateCustomer(Customer customer);
}