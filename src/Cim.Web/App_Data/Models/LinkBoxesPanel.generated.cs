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
	/// <summary>Link Boxes Panel</summary>
	[PublishedContentModel("linkBoxesPanel")]
	public partial class LinkBoxesPanel : Panel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "linkBoxesPanel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LinkBoxesPanel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LinkBoxesPanel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bottom Link
		///</summary>
		[ImplementPropertyType("bottomLink")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker BottomLink
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("bottomLink"); }
		}

		///<summary>
		/// Left Link
		///</summary>
		[ImplementPropertyType("leftLink")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker LeftLink
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("leftLink"); }
		}

		///<summary>
		/// Right Link
		///</summary>
		[ImplementPropertyType("rightLink")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker RightLink
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("rightLink"); }
		}

		///<summary>
		/// Top Link
		///</summary>
		[ImplementPropertyType("topLink")]
		public Gibe.LinkPicker.Umbraco.Models.LinkPicker TopLink
		{
			get { return this.GetPropertyValue<Gibe.LinkPicker.Umbraco.Models.LinkPicker>("topLink"); }
		}
	}
}
