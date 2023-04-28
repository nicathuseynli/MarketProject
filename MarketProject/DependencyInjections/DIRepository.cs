using MarketProject.Repositories.Abstarctions;
using MarketProject.Repositories.Implementations;

namespace MarketProject.DependencyInjections;
public static class DIRepository
{
    public static IServiceCollection AddRepositoryLayer(this IServiceCollection repositories)
    {
        repositories.AddScoped<IProductRepository, ProductRepository>();
        repositories.AddScoped<ICategoryRepository, CategoryRepository>();
        repositories.AddScoped<IPartnerCompanyRepository, PartnerCompanyRepository>();
        repositories.AddScoped<IMarketRepository, MarketRepository>();
        return repositories;
    }
}
