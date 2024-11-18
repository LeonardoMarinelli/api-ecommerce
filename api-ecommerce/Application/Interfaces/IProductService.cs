using api_ecommerce.Domain.Entities;

namespace api_ecommerce.Application.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();
    bool ReserveProduct(Guid productId, Guid customerId);
    Product CreateProduct(string name, ProductStatus status);
}