using SitecoreForms.Feature.Hero.Factories;
using SitecoreForms.Feature.Hero.Mediators;
using SitecoreForms.Feature.Hero.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace SitecoreForms.Feature.Hero.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IHeroMediator, HeroMediator>();
            serviceCollection.AddTransient<IHeroService, HeroService>();
            serviceCollection.AddTransient<IHeroViewModelFactory, HeroViewModelFactory>();
        }
    }
}
