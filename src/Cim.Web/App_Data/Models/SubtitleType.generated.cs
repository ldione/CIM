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
	// Mixin content Type 1123 with alias "subtitleType"
	/// <summary>Subtitle Type</summary>
	public partial interface ISubtitleType : IPublishedContent
	{
		/// <summary>Subtitle</summary>
		string Subtitle { get; }
	}

	/// <summary>Subtitle Type</summary>
	[PublishedContentModel("subtitleType")]
	public partial class SubtitleType : PublishedContentModel, ISubtitleType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "subtitleType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SubtitleType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SubtitleType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return GetSubtitle(this); }
		}

		/// <summary>Static getter for Subtitle</summary>
		public static string GetSubtitle(ISubtitleType that) { return that.GetPropertyValue<string>("subtitle"); }
	}
}
