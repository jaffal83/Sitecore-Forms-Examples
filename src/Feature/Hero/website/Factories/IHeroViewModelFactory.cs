using SitecoreForms.Feature.Hero.Models;
using SitecoreForms.Feature.Hero.ViewModels;

namespace SitecoreForms.Feature.Hero.Factories
{
    public interface IHeroViewModelFactory
    {
        HeroViewModel CreateHeroViewModel(IHero heroItemDataSource, bool isExperienceEditor);
    }
}
