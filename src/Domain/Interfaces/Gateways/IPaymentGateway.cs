namespace Domain.Interfaces.Gateways;

public interface IPaymentGateway
{
    void MakePayment(double amount);
}