using Domain.Interfaces.Gateways;
using Domain.Interfaces.Services;

namespace Infrastructure.Adapters;

public class PaymentAdapter(IPaymentGateway gateway) : IPaymentService
{
    private IPaymentGateway Gateway { get; } = gateway;

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processando pagamento...");

        if (amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than zero");
        }

        Gateway.MakePayment(amount);
    }
}