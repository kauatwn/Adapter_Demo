namespace Domain.Interfaces.Services;

public interface IPaymentService
{
    void ProcessPayment(double amount);
}