using Glass.Mapper.Sc.Pipelines.AddMaps;
using SitecoreForms.Foundation.ORM.Extensions;

namespace SitecoreForms.Foundation.ORM.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("SitecoreForms.Foundation.ORM");
        }
    }
}
