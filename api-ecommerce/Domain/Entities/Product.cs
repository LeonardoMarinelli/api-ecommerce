namespace api_ecommerce.Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public ProductStatus Status { get; set; } = ProductStatus.Available;
}

public enum ProductStatus
{
    Available,
    Reserved,
    Unavailable
}