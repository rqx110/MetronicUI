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
    
    #line 1 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Nav_TopMenu.cshtml")]
    public partial class _Views_Shared__Nav_TopMenu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Nav_TopMenu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
  
    var menu = ViewBag.Menu as IMenu;
    var home = NewLife.Cube.Setting.Current.StartPage;
    var title = ViewBag.Title + "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!--导航-->\r\n<button");

WriteLiteral(" class=\"kt-header-menu-wrapper-close\"");

WriteLiteral(" id=\"kt_header_menu_mobile_close_btn\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-close\"");

WriteLiteral("></i></button>\r\n<div");

WriteLiteral(" class=\"kt-header-menu-wrapper\"");

WriteLiteral(" id=\"kt_header_menu_wrapper\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"kt_header_menu\"");

WriteLiteral(" class=\"kt-header-menu kt-header-menu-mobile  kt-header-menu--layout-default \"");

WriteLiteral(">\r\n\r\n        <ul");

WriteLiteral(" class=\"kt-menu__nav\"");

WriteLiteral(">\r\n            <li");

WriteLiteral(" class=\"kt-menu__item  kt-menu__item--submenu kt-menu__item--rel kt-menu__item--a" +
"ctive\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 644), Tuple.Create("\"", 669)
            
            #line 15 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
, Tuple.Create(Tuple.Create("", 651), Tuple.Create<System.Object, System.Int32>(Url.Content(home)
            
            #line default
            #line hidden
, 651), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"kt-menu__link-text\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-home\"");

WriteLiteral("></i></span></a>\r\n            </li>\r\n");

            
            #line 17 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
             if (menu != null)
            {
                foreach (IMenu item in (menu as IEntityTree).AllParents)
                {
                    if (item.ID != 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"kt-menu__item  kt-menu__item--submenu kt-menu__item--rel kt-menu__item--a" +
"ctive\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"kt-menu__link-text\"");

WriteLiteral(">/</span>\r\n                        </li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"kt-menu__item  kt-menu__item--submenu kt-menu__item--rel kt-menu__item--a" +
"ctive\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><span");

WriteLiteral(" class=\"kt-menu__link-text\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
                                                                    Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                        </li>\r\n");

            
            #line 29 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"kt-menu__item  kt-menu__item--submenu kt-menu__item--rel kt-menu__item--a" +
"ctive\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"kt-menu__link-text\"");

WriteLiteral(">/</span>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"kt-menu__item  kt-menu__item--submenu kt-menu__item--rel kt-menu__item--a" +
"ctive\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><span");

WriteLiteral(" class=\"kt-menu__link-text\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Shared\_Nav_TopMenu.cshtml"
                                                         Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
