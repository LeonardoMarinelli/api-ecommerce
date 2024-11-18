namespace api_ecommerce.Domain.Entities;

public class CreateProductRequest
{
    public required string Name { get; set; }
    public ProductStatus Status { get; set; }
}