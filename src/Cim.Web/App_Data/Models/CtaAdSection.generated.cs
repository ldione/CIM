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
	/// <summary>CTA Ad Section</summary>
	[PublishedContentModel("ctaAdSection")]
	public partial class CtaAdSection : CtaSection, IAdType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ctaAdSection";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CtaAdSection(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CtaAdSection, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Ad Code
		///</summary>
		[ImplementPropertyType("adCode")]
		public string AdCode
		{
			get { return Umbraco.Web.PublishedContentModels.AdType.GetAdCode(this); }
		}

		///<summary>
		/// Ad Image
		///</summary>
		[ImplementPropertyType("adImage")]
		public IPublishedContent AdImage
		{
			get { return Umbraco.Web.PublishedContentModels.AdType.GetAdImage(this); }
		}

		///<summary>
		/// Ad Link Url
		///</summary>
		[ImplementPropertyType("adLinkUrl")]
		public string AdLinkUrl
		{
			get { return Umbraco.Web.PublishedContentModels.AdType.GetAdLinkUrl(this); }
		}
	}
}
