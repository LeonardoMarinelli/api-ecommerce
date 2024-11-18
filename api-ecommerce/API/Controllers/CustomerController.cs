using api_ecommerce.Application.Interfaces;
using api_ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api_ecommerce.API.Controllers;

[ApiController]
[Route("customer")]
public class CustomerController(IReservationService reservationService) : ControllerBase
{
    private readonly ICustomerService _customerService;
    
    [HttpPost]
    public IActionResult CreateCustomer([FromBody] CreateCustomerRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            return BadRequest("O nome do cliente é obrigatório.");

        var customer = _customerService.CreateCustomer(request.Name);
        return CreatedAtAction(nameof(CreateCustomer), new { id = customer.Id }, customer);
    }
    
    [HttpGet("{idCustomer:guid}/reservations")]
    public IActionResult GetCustomerReservations(Guid idCustomer)
    {
        var reservations = reservationService.GetReservationsByCustomer(idCustomer);
        if (reservations.Count is 0) return NotFound("Nenhum produto reservado por este cliente.");
        
        return Ok(reservations);
    }
}