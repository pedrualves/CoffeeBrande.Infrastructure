// namespace CoffeeBrand.Infrastructure;
using Microsoft;
using CoffeeBrand.Domain;

namespace CoffeeBrand.Infrastructure
{
    public static class Startup
    {
        public static void ConfigureServices(ICoffeeBrandRepository services)
        {
            // Configuração da injeção de dependência para as implementações da infraestrutura
            services.AddSingleton<ICoffeeBrandRepository, InMemoryCoffeeBrandRepository>();
        }
    }
}
