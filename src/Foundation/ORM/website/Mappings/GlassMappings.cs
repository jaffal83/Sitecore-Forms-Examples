using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using SitecoreForms.Foundation.ORM.Models;

namespace SitecoreForms.Foundation.ORM
{
    public class GlassMappings : SitecoreGlassMap<IGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Info(f => f.BaseTemplateIds).InfoType(SitecoreInfoType.BaseTemplateIds);
            });
        }
    }
}
