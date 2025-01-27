using Application.Abstractions.UseCases;
using Application.UseCases;
using Domain.Interfaces.Gateways;
using Domain.Interfaces.Services;
using Infrastructure.Adapters;
using Infrastructure.Gateways.Payments;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
    }

    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddAdapters(services);
        AddGateways(services);
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IProcessPaymentUseCase, ProcessPaymentUseCase>();
    }

    private static void AddAdapters(IServiceCollection services)
    {
        services.AddScoped<IPaymentService, PaymentAdapter>();
    }

    private static void AddGateways(IServiceCollection services)
    {
        services.AddScoped<IPaymentGateway, PagBankPaymentGateway>();
    }
}