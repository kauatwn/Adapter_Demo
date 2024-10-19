using Domain.Interfaces.Gateways;
using Domain.Interfaces.Services;

namespace Infrastructure.Adapters;

public class PaymentAdapter(IPaymentGateway paymentGateway) : IPaymentService
{
    private IPaymentGateway PaymentGateway { get; } = paymentGateway;

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processando pagamento...");

        if (amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than zero");
        }

        PaymentGateway.MakePayment(amount);
    }
}