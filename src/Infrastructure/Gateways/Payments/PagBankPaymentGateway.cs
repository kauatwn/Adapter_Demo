using Domain.Interfaces.Gateways;

namespace Infrastructure.Gateways.Payments;

public class PagBankPaymentGateway : IPaymentGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Pagamento de {amount:C} realizado via PagBank");
    }
}