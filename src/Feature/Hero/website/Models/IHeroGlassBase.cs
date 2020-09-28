using SitecoreForms.Foundation.ORM.Models;

namespace SitecoreForms.Feature.Hero.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface IHeroGlassBase : IGlassBase
    {
    }
}
