﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MUI.WebSite;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 1 "..\..\Views\Shared\_Nav_Subheader.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_Nav_Subheader.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Nav_Subheader.cshtml")]
    public partial class _Views_Shared__Nav_Subheader_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Nav_Subheader_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_Nav_Subheader.cshtml"
  
    var menu = ViewBag.Menu as IMenu;
    var home = NewLife.Cube.Setting.Current.StartPage;
    var title = ViewBag.Title + "";

            
            #line default
            #line hidden
WriteLiteral("                                                 \r\n\r\n<!-- begin:: Subheader -->\r\n" +
"<div");

WriteLiteral(" class=\"kt-subheader kt-grid__item\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-subheader__main\"");

WriteLiteral(">\r\n        <h3");

WriteLiteral(" class=\"kt-subheader__title\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\_Nav_Subheader.cshtml"
                                   Write(title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        <span");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-separator kt-hidden\"");

WriteLiteral("></span>\r\n\r\n        <!-- 页面导航区 -->\r\n        <div");

WriteLiteral(" class=\"kt-subheader__breadcrumbs\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-home\"");

WriteLiteral("><i");

WriteLiteral(" class=\"flaticon2-shelter\"");

WriteLiteral("></i></a>\r\n            <span");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-separator\"");

WriteLiteral("></span>\r\n");

            
            #line 19 "..\..\Views\Shared\_Nav_Subheader.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\_Nav_Subheader.cshtml"
             if (menu != null)
            {
                foreach (IMenu item in (menu as IEntityTree).AllParents)
                {
                    if (item.ID != 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-link\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Shared\_Nav_Subheader.cshtml"
                                                                      Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                        <span");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-separator\"");

WriteLiteral("></span>\r\n");

            
            #line 27 "..\..\Views\Shared\_Nav_Subheader.cshtml"
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            <span");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-separator\"");

WriteLiteral("></span>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"kt-subheader__breadcrumbs-link\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Shared\_Nav_Subheader.cshtml"
                                                           Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n</div>    \r\n<!-- end:: Subheader -->\r\n");

        }
    }
}
#pragma warning restore 1591