using System.Linq;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace Cim.Web.Core
{
    public class PublishedContentService
    {
        private readonly UmbracoHelper umbraco;

        public PublishedContentService(
            UmbracoHelper umbraco)
        {
            this.umbraco = umbraco;
        }

        public Settings GetSettings()
        {
            return (Settings)umbraco.TypedContentAtRoot().First(c => c.DocumentTypeAlias == Settings.ModelTypeAlias);
        }

        public Navigation GetNavigation()
        {
            return GetSettings().FirstChildAs<Navigation>();
        }
    }
}