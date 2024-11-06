using BusTransportationModel.Data;
using Microsoft.EntityFrameworkCore;
using BusTransportationModel.Service.Settings;

namespace BusTransportationModel.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, BusTransportationModelSettings settings)
    {
        services.AddDbContextFactory<BusModelDbContext>(
            options => { options.UseNpgsql(settings.BusTransportationModelDbContextConnectionString); }, // Используйте UseNpgsql
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<BusModelDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate(); 
    }
}