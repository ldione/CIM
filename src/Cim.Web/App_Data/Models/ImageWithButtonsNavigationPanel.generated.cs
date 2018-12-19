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
	/// <summary>Image With Buttons Navigation Panel</summary>
	[PublishedContentModel("imageWithButtonsNavigationPanel")]
	public partial class ImageWithButtonsNavigationPanel : Panel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "imageWithButtonsNavigationPanel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ImageWithButtonsNavigationPanel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ImageWithButtonsNavigationPanel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Buttons
		///</summary>
		[ImplementPropertyType("buttons")]
		public Umbraco.Web.Models.RelatedLinks Buttons
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("buttons"); }
		}

		///<summary>
		/// Left Block Number
		///</summary>
		[ImplementPropertyType("leftBlockNumber")]
		public string LeftBlockNumber
		{
			get { return this.GetPropertyValue<string>("leftBlockNumber"); }
		}

		///<summary>
		/// Left Block Title
		///</summary>
		[ImplementPropertyType("leftBlockTitle")]
		public string LeftBlockTitle
		{
			get { return this.GetPropertyValue<string>("leftBlockTitle"); }
		}
	}
}