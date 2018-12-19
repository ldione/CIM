using Cim.Web.Core;
using Cim.Web.Models.Shared;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Cim.Web.Controllers.Surface
{
    public class SharedController : SurfaceController
    {
        private readonly PublishedContentService publishedContentService;

        public SharedController()
        {
            publishedContentService = new PublishedContentService(Umbraco);
        }

        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }
        
        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Login()
        {
            return PartialView();
        }
        
        [ChildActionOnly]
        public ActionResult Navigation()
        {
            var model = new NavigationModel();
            model.Navigation = publishedContentService.GetNavigation();
            return PartialView(model);
        }
    }
}