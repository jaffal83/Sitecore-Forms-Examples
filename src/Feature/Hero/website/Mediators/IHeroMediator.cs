using SitecoreForms.Feature.Hero.ViewModels;
using SitecoreForms.Foundation.Core.Models;

namespace SitecoreForms.Feature.Hero.Mediators
{
    public interface IHeroMediator
    {
        MediatorResponse<HeroViewModel> RequestHeroViewModel();
    }
}
