namespace api_ecommerce.Domain.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public DateTime ExpirationDate { get; set; }
}