using api_ecommerce.Application.Interfaces;
using api_ecommerce.Domain.Entities;
using api_ecommerce.Infraestructure.Data;

namespace api_ecommerce.Application.Services;

public class ProductService(AppDbContext dbContext) : IProductService
{
    public List<Product> GetAllProducts()
    {
        return dbContext.Products.ToList();
    }

    public bool ReserveProduct(Guid productId, Guid customerId)
    {
        var customer = dbContext.Customers.FirstOrDefault(c => c.Id == customerId);
        if (customer is null) throw new Exception("Cliente não encontrado. Verifique o ID informado.");

        var product = dbContext.Products.FirstOrDefault(p => p.Id == productId && p.Status == ProductStatus.Available);
        if (product is null) return false;

        var reservation = new Reservation
        {
            Id = Guid.NewGuid(),
            CustomerId = customerId,
            ProductId = productId,
            ExpirationDate = DateTime.UtcNow.AddDays(3)
        };

        product.Status = ProductStatus.Reserved;
        dbContext.Reservations.Add(reservation);
        dbContext.SaveChanges();
        return true;
    }

    public Product CreateProduct(string name, ProductStatus status)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = name,
            Status = status
        };

        dbContext.Products.Add(product);
        dbContext.SaveChanges();
        return product;
    }
}