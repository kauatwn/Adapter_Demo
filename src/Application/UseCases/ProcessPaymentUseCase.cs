using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.UseCases;

public class ProcessPaymentUseCase(IPaymentService service) : IProcessPaymentUseCase
{
    private IPaymentService Service { get; } = service;

    public Order Execute(Order order)
    {
        Service.ProcessPayment(order.Total);

        return order;
    }
}