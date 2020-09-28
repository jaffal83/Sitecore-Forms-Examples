using SitecoreForms.Foundation.ORM.Models;

namespace SitecoreForms.Foundation.Content.Tests.Models
{
    public interface ITestItem : IGlassBase
    {
        string Title { get; set; }
    }
}
