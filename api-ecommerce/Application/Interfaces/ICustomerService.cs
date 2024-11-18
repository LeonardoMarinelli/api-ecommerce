using api_ecommerce.Domain.Entities;

namespace api_ecommerce.Application.Interfaces;

public interface ICustomerService
{
    Customer CreateCustomer(string name);
}