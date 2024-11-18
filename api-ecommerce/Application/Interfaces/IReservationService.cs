using api_ecommerce.Domain.Entities;

namespace api_ecommerce.Application.Interfaces;

public interface IReservationService
{
    List<Product> GetReservationsByCustomer(Guid customerId);
}