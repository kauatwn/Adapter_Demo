using Application.Abstractions.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    [HttpPost("ProcessPayment")]
    [ProducesResponseType<Order>(StatusCodes.Status200OK)]
    public IActionResult ProcessPayment(IProcessPaymentUseCase useCase, Order order)
    {
        return Ok(useCase.Execute(order));
    }
}