using Cim.Web.Core.Users;
using Cim.Web.Models.Users;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Cim.Web.Controllers.Surface
{
    public class UsersController : SurfaceController
    {
        private readonly UsersService usersService;

        public UsersController()
        {
            this.usersService = new UsersService(Umbraco, Services.MemberService);
        }

        [ChildActionOnly]
        public ActionResult Create()
        {
            var model = new CreateUserModel();
            return PartialView(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [NotChildAction]
        public ActionResult Create(CreateUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var email = model.Email.Trim();
            var isExistingUser = usersService.IsExistingUser(email);
            if (isExistingUser)
            {
                ModelState.AddModelError("", Umbraco.GetDictionaryValue("User Exists Message"));
                return CurrentUmbracoPage();
            }

            var user = usersService.Create(model);

            return RedirectToCurrentUmbracoPage();
        }

        [ChildActionOnly]
        public ActionResult Login()
        {
            var model = new LoginModel();
            return PartialView(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [NotChildAction]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var login = Members.Login(model.Email, model.Password);
            if (!login)
            {
                return CurrentUmbracoPage();
            }

            return RedirectToCurrentUmbracoPage();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Members.Logout();
            return Redirect("~/");
        }
    }
}