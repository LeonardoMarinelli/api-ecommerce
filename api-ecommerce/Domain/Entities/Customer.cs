namespace api_ecommerce.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<Reservation> Reservations { get; set; } = [];
}