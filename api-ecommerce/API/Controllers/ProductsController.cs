using api_ecommerce.Application.Interfaces;
using api_ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api_ecommerce.API.Controllers;

[ApiController]
[Route("products")]
public class ProductsController(IProductService productService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = productService.GetAllProducts();
        return Ok(products);
    }

    [HttpPost("{productId:guid}/reserve/{customerId:guid}")]
    public IActionResult ReserveProduct(Guid productId, Guid customerId)
    {
        var result = productService.ReserveProduct(productId, customerId);
        if (result) return Ok("Produto reservado com sucesso!");
        
        return BadRequest("Erro ao reservar o produto. Verifique a requisição e tente novamente.");
    }

    [HttpPost]
    public IActionResult CreateProduct([FromBody] CreateProductRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name)) return BadRequest("O nome do produto não pode ser nulo.");
        
        var product = productService.CreateProduct(request.Name, request.Status);
        return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
    }
}