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
	/// <summary>Panel</summary>
	[PublishedContentModel("panel")]
	public partial class Panel : PublishedContentModel, INavigationPanelBorder, INavigationPanelWidth
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "panel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Panel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Panel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Right Border Line
		///</summary>
		[ImplementPropertyType("rightBorderLine")]
		public bool RightBorderLine
		{
			get { return Umbraco.Web.PublishedContentModels.NavigationPanelBorder.GetRightBorderLine(this); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("width")]
		public string Width
		{
			get { return Umbraco.Web.PublishedContentModels.NavigationPanelWidth.GetWidth(this); }
		}
	}
}
