using api_ecommerce.Application.Interfaces;
using api_ecommerce.Domain.Entities;
using api_ecommerce.Infraestructure.Data;

namespace api_ecommerce.Application.Services;

public class CustomerService(AppDbContext dbContext) : ICustomerService
{
    public Customer CreateCustomer(string name)
    {
        var customer = new Customer
        {
            Id = Guid.NewGuid(),
            Name = name
        };

        dbContext.Customers.Add(customer);
        dbContext.SaveChanges();
        return customer;
    }
}