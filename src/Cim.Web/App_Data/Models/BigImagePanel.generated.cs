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
	/// <summary>Big Image Panel</summary>
	[PublishedContentModel("bigImagePanel")]
	public partial class BigImagePanel : Panel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bigImagePanel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BigImagePanel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BigImagePanel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker Link
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("link"); }
		}
	}
}
