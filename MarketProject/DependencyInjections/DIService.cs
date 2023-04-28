using MarketProject.Services.Implementations;
using MarketProject.Services.Interfaces;

namespace MarketProject.DependencyInjections;
public static class DIService
{
    public static IServiceCollection AddServiceLayer(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IPartnerCompanyService, PartnerCompanyService>();
        services.AddScoped<IMarketService, MarketService>();
        return services;
    }
}
