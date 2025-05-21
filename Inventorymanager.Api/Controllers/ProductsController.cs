using InventoryManager.Api.Mediator.Commands;
using InventoryManager.Api.Repositories.Interfaces;
using InventoryManager.Infrastructure.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.Api.Controllers;

[ApiController]
[Route("Api/[controller]")]

public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IProductRepository _productRepository;

    public ProductsController(IMediator mediator, IProductRepository productRepository)
    {
        _mediator = mediator;
        _productRepository = productRepository;
    }

    [HttpPost("AddProduct")]
    public async Task<ActionResult> AddProduct([FromBody] AddProductCommand addProductCommand)
    {
        try
        {
            var result = await _mediator.Send(addProductCommand);
            return Ok(result);
        }
        catch (Exception a)
        {
            Console.WriteLine(a);
            throw;
        }
    }
    [HttpPost("OutProduct")]
    public async Task<ActionResult> OutProduct([FromBody] OutProductCommand outProductCommand)
    {
        try
        {
            var result = await _mediator.Send(outProductCommand);
            return Ok(result);
        }
        catch (Exception a)
        {
            Console.WriteLine(a);
            throw;
        }
    }
    
    [HttpGet("GetAllProducts")]
    public async Task<ActionResult> AddProduct()
    {
        try
        {
            var result = _productRepository.GetAllProducts();
            
            return Ok(result);
        }
        catch (Exception a)
        {
            Console.WriteLine(a);
            throw;
        }
    }
    
    [HttpPost("GetAllStockTransaction")]
    public async Task<ActionResult> GetAllStockTransaction([FromBody] FilterCommand command)
    {
        try
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        catch (Exception a)
        {
            Console.WriteLine(a);
            throw;
        }
    }
}