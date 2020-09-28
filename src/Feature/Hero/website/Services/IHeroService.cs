using SitecoreForms.Feature.Hero.Models;
using SitecoreForms.Foundation.Search.Models;

namespace SitecoreForms.Feature.Hero.Services
{
    public interface IHeroService
    {
        IHero GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
