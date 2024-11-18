using api_ecommerce.Application.Interfaces;
using api_ecommerce.Domain.Entities;
using api_ecommerce.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace api_ecommerce.Application.Services;

public class ReservationService(AppDbContext dbContext) : IReservationService
{
    public List<Product> GetReservationsByCustomer(Guid customerId)
    {
        var reservations = dbContext.Reservations
            .Include(r => r.Product)
            .Where(r => r.CustomerId == customerId && r.ExpirationDate > DateTime.UtcNow)
            .Select(r => r.Product)
            .ToList();

        return reservations;
    }
}