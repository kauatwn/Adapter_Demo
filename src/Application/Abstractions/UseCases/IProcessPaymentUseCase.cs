using Domain.Entities;

namespace Application.Abstractions.UseCases;

public interface IProcessPaymentUseCase
{
    Order Execute(Order order);
}