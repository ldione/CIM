using System;
using Cim.Web.Models.Users;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;

namespace Cim.Web.Core.Users
{
    public class UsersService
    {
        private readonly UmbracoHelper umbraco;
        private readonly IMemberService memberService;

        public UsersService(
            UmbracoHelper umbraco,
            IMemberService memberService)
        {
            this.umbraco = umbraco;
            this.memberService = memberService;
        }

        public IPublishedContent GetByEmail(string email)
        {
            return umbraco.MembershipHelper.GetByEmail(email);
        }

        public bool IsExistingUser(string email)
        {
            return GetByEmail(email) != null;
        }

        public IMember Create(CreateUserModel model)
        {
            var member = memberService.CreateMember(model.Email, model.Email, model.FirstName + " " + model.LastName, "Member");
            member.SetValue(nameof(model.FirstName), model.FirstName);
            member.SetValue(nameof(model.LastName), model.LastName);

            memberService.Save(member);
            memberService.SavePassword(member, model.Password);
            return member;
        }
    }
}