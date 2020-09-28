using Glass.Mapper.Sc.Pipelines.AddMaps;
using SitecoreForms.Foundation.ORM.Extensions;

namespace SitecoreForms.Feature.Hero.ORM
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("SitecoreForms.Feature.Hero");
        }
    }
}
