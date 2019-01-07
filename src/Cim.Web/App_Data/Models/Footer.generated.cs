//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Footer</summary>
	[PublishedContentModel("footer")]
	public partial class Footer : PublishedContentModel, ILinkType, ITextType, ITitleType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "footer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Footer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Footer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("address")]
		public string Address
		{
			get { return this.GetPropertyValue<string>("address"); }
		}

		///<summary>
		/// Address Url
		///</summary>
		[ImplementPropertyType("addressUrl")]
		public string AddressUrl
		{
			get { return this.GetPropertyValue<string>("addressUrl"); }
		}

		///<summary>
		/// Contacts Title
		///</summary>
		[ImplementPropertyType("contactsTitle")]
		public string ContactsTitle
		{
			get { return this.GetPropertyValue<string>("contactsTitle"); }
		}

		///<summary>
		/// Contact Us Link
		///</summary>
		[ImplementPropertyType("contactUsLink")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker ContactUsLink
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("contactUsLink"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Facebook
		///</summary>
		[ImplementPropertyType("facebook")]
		public string Facebook
		{
			get { return this.GetPropertyValue<string>("facebook"); }
		}

		///<summary>
		/// Instagram
		///</summary>
		[ImplementPropertyType("instagram")]
		public string Instagram
		{
			get { return this.GetPropertyValue<string>("instagram"); }
		}

		///<summary>
		/// Linkedin
		///</summary>
		[ImplementPropertyType("linkedin")]
		public string Linkedin
		{
			get { return this.GetPropertyValue<string>("linkedin"); }
		}

		///<summary>
		/// Office Hours
		///</summary>
		[ImplementPropertyType("officeHours")]
		public string OfficeHours
		{
			get { return this.GetPropertyValue<string>("officeHours"); }
		}

		///<summary>
		/// Phone
		///</summary>
		[ImplementPropertyType("phone")]
		public string Phone
		{
			get { return this.GetPropertyValue<string>("phone"); }
		}

		///<summary>
		/// Privacy Policy Link
		///</summary>
		[ImplementPropertyType("privacyPolicyLink")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker PrivacyPolicyLink
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("privacyPolicyLink"); }
		}

		///<summary>
		/// Twitter
		///</summary>
		[ImplementPropertyType("twitter")]
		public string Twitter
		{
			get { return this.GetPropertyValue<string>("twitter"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker Link
		{
			get { return Umbraco.Web.PublishedContentModels.LinkType.GetLink(this); }
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("text")]
		public string Text
		{
			get { return Umbraco.Web.PublishedContentModels.TextType.GetText(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleType.GetTitle(this); }
		}
	}
}