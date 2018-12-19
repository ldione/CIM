using System.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace Cim.Web.Core
{
    public static class HtmlHelperExtensions
    {
        public static string GetWidthClass(this HtmlHelper html, INavigationPanelWidth panel)
        {
            return html.GetWidthClass(panel.Width);
        }

        public static string GetWidthClass(this HtmlHelper html, string widthValue)
        {
            switch (widthValue)
            {
                case "1 / 12":
                    return "col-sm-1";
                case "1 / 6":
                    return "col-sm-2";
                case "1 / 4":
                    return "col-sm-3";
                case "1 / 3":
                    return "col-sm-4";
                case "5 / 12":
                    return "col-sm-5";
                case "1 / 2":
                    return "col-sm-6";
                case "7 / 12":
                    return "col-sm-7";
                case "2 / 3":
                    return "col-sm-8";
                case "3 / 4":
                    return "col-sm-9";
                case "5 / 6":
                    return "col-sm-10";
                case "11 / 12":
                    return "col-sm-11";
                case "Full width":
                default:
                    return "col-sm-12";
            }
        }

        public static string GetBorderClass(this HtmlHelper html, INavigationPanelBorder panel)
        {
            return panel.RightBorderLine ? "bdr" : "";
        }
    }
}