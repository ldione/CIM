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

        public HomePage GetHomePage()
        {
            var home = (HomePage)umbraco.AssignedContentItem.AncestorOrSelf(HomePage.ModelTypeAlias);
            return home;
        }

        public Settings GetSettings()
        {
            var settings = (Settings)umbraco.TypedContentAtRoot()
                .First(c => c.DocumentTypeAlias == Settings.ModelTypeAlias &&
                c.GetCulture().Name == umbraco.AssignedContentItem.GetCulture().Name);
            return settings;
        }

        public Navigation GetNavigation()
        {
            return GetSettings().FirstChildAs<Navigation>();
        }

        public Footer GetFooter()
        {
            return GetSettings().FirstChildAs<Footer>();
        }

        public HomePage GetOtherLanguageHome()
        {
            var home = GetHomePage();
            var otherLangHome = umbraco.TypedContentAtRoot()
                .First(c => c.DocumentTypeAlias == HomePage.ModelTypeAlias && c.Id != home.Id);
            return (HomePage)otherLangHome;
        }

        public CreateAccountPage GetCreateAccountPage()
        {
            var result = GetHomePage().FirstChildAs<CreateAccountPage>();
            return result;
        }
    }
}