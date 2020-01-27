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
    
    #line 1 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    
    #line 2 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
    using NewLife.Model;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 3 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Nav_AsideMenu.cshtml")]
    public partial class _Views_Shared__Nav_AsideMenu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Nav_AsideMenu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;

    var fact = ObjectContainer.Current.Resolve<IMenuFactory>();

    var Menus = fact.Root.Childs;
    if (user != null && user.Role != null)
    {
        Menus = fact.GetMySubMenus(fact.Root.ID, user);
    }

    // 如果顶级只有一层，并且至少有三级目录，则提升一级
    if (Menus.Count == 1 && Menus[0].Childs.All(m => m.Childs.Count > 0)) { Menus = Menus[0].Childs; }

    String[] icons = new String[] { "flaticon-cogwheel", "flaticon-squares-4", "flaticon-imac", "flaticon-responsive", "flaticon-cogwheel",
        "flaticon-interface-1", "flaticon-interface-3", "flaticon-web", "flaticon-interface-8", "flaticon-time-1", "flaticon-app",
        "flaticon-map-location","flaticon-grid-menu-v2","flaticon-paper-plane", "flaticon-network", "flaticon-squares-3",
        "flaticon-interface-9","flaticon-graphic-2","flaticon-layers","flaticon-line-graph","flaticon-clock-1", "flaticon-layers" };
    String[] svgIcons = new String[]
    {
        "Shopping/Box#2.svg", "General/Duplicate.svg", "General/Attachment#2.svg", "Shopping/Box#1.svg", "Shopping/Wallet.svg",
        "Design/Substract.svg", "Design/Layers.svg", "Design/Interselect.svg", "Home/Water-mixer.svg", "Home/Mirror.svg", "Home/Library.svg",
        "Home/Book-open.svg", "Home/Cupboard.svg", "Home/Commode#2.svg", "Home/Commode#1.svg", "Design/Line.svg", "Shopping/Barcode-read.svg",
        "Shopping/Chart-bar#1.svg", "General/Settings-1.svg", "Communication/Send.svg", "Communication/Group-chat.svg", "Map/Direction#2.svg",
        "Layout/Layout-right-panel-1.svg", "Layout/Layout-top-panel-4.svg", "Layout/Layout-4-blocks.svg", "Layout/Layout-3d.svg",
        "Layout/Layout-top-panel-2.svg", "Layout/Layout-horizontal.svg", "Layout/Layout-arrange.svg", "Devices/Diagnostics.svg",
        "Tools/Pantone.svg", "Code/Git#2.svg", "Code/Compiling.svg"
            };

    Int32 _idx = 0;

    var cfg = ViewBag.Config as SysConfig;
    var name = cfg == null ? "" : cfg.DisplayName;

    var _area = ViewContext.RouteData.DataTokens["area"] + "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!--侧边栏菜单-->\r\n<div");

WriteLiteral(" class=\"kt-aside-menu-wrapper kt-grid__item kt-grid__item--fluid\"");

WriteLiteral(" id=\"kt_aside_menu_wrapper\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"kt_aside_menu\"");

WriteLiteral(" class=\"kt-aside-menu \"");

WriteLiteral(" data-ktmenu-vertical=\"1\"");

WriteLiteral(" data-ktmenu-scroll=\"1\"");

WriteLiteral(" data-ktmenu-dropdown-timeout=\"500\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"kt-menu__nav\"");

WriteLiteral(">\r\n            <!-- 循环加载菜单项 -->\r\n");

            
            #line 46 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
             foreach (var menu in Menus.Where(m => m.Visible))
            {
                var childs = fact.GetMySubMenus(menu.ID, user).Where(m => m.Visible);
                if (_idx >= icons.Length)
                {
                    _idx = 0;
                }

                if (childs.Any())
                {
                    var _open = _area == menu.Name ? "kt-menu__item--open" : "";

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 2928), Tuple.Create("\"", 2979)
, Tuple.Create(Tuple.Create("", 2936), Tuple.Create("kt-menu__item", 2936), true)
, Tuple.Create(Tuple.Create(" ", 2949), Tuple.Create("kt-menu__item--submenu", 2950), true)
            
            #line 57 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
, Tuple.Create(Tuple.Create(" ", 2972), Tuple.Create<System.Object, System.Int32>(_open
            
            #line default
            #line hidden
, 2973), false)
);

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" data-ktmenu-submenu-toggle=\"hover\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"javascript:;\"");

WriteLiteral(" class=\"kt-menu__link kt-menu__toggle\"");

WriteLiteral(">\r\n");

            
            #line 59 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                             if (!menu.Icon.IsNullOrEmpty())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3253), Tuple.Create("\"", 3290)
, Tuple.Create(Tuple.Create("", 3261), Tuple.Create("kt-menu__link-icon", 3261), true)
            
            #line 61 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
, Tuple.Create(Tuple.Create(" ", 3279), Tuple.Create<System.Object, System.Int32>(menu.Icon
            
            #line default
            #line hidden
, 3280), false)
);

WriteLiteral(" style=\"font-size:20px;\"");

WriteLiteral("></i>\r\n");

            
            #line 62 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3452), Tuple.Create("\"", 3493)
, Tuple.Create(Tuple.Create("", 3460), Tuple.Create("kt-menu__link-icon", 3460), true)
            
            #line 65 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
, Tuple.Create(Tuple.Create(" ", 3478), Tuple.Create<System.Object, System.Int32>(icons[_idx++]
            
            #line default
            #line hidden
, 3479), false)
);

WriteLiteral(" style=\"font-size:20px;\"");

WriteLiteral("></i>\r\n");

            
            #line 66 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"kt-menu__link-text  pl-2\"");

WriteLiteral(" style=\"font-size:16px;\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                                                                                      Write(menu.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            <i");

WriteLiteral(" class=\"kt-menu__ver-arrow la la-angle-right\"");

WriteLiteral("></i>\r\n                        </a>\r\n                        <div");

WriteLiteral(" class=\"kt-menu__submenu\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"kt-menu__arrow\"");

WriteLiteral("></span>\r\n                            <ul");

WriteLiteral(" class=\"kt-menu__subnav\"");

WriteLiteral(">\r\n                                <li");

WriteLiteral(" class=\"kt-menu__item kt-menu__item--parent\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"kt-menu__link\"");

WriteLiteral("><span");

WriteLiteral(" class=\"kt-menu__link-text\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                                                                                            Write(menu.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span></span>\r\n                                </li>\r\n");

            
            #line 76 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                                 foreach (var subMenu in childs)
                                {
                                    
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                               Write(Html.Partial("_Nav_AsideMenu_Item", subMenu));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                                                                                 
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n              " +
"      </li>\r\n");

            
            #line 83 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                }
                else
                {
                    var url = menu.Url.IsNullOrEmpty() ? "" : Url.Content(menu.Url);


            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"kt-menu__item\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4793), Tuple.Create("\"", 4804)
            
            #line 89 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
, Tuple.Create(Tuple.Create("", 4800), Tuple.Create<System.Object, System.Int32>(url
            
            #line default
            #line hidden
, 4800), false)
);

WriteLiteral(" class=\"kt-menu__link\"");

WriteLiteral(" target=\"_self\"");

WriteLiteral(">\r\n");

            
            #line 90 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                             if (!@menu.Icon.IsNullOrEmpty())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 4973), Tuple.Create("\"", 5010)
, Tuple.Create(Tuple.Create("", 4981), Tuple.Create("kt-menu__link-icon", 4981), true)
            
            #line 92 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
, Tuple.Create(Tuple.Create(" ", 4999), Tuple.Create<System.Object, System.Int32>(menu.Icon
            
            #line default
            #line hidden
, 5000), false)
);

WriteLiteral(" style=\"font-size:20px;\"");

WriteLiteral("></i>\r\n");

            
            #line 93 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 5172), Tuple.Create("\"", 5213)
, Tuple.Create(Tuple.Create("", 5180), Tuple.Create("kt-menu__link-icon", 5180), true)
            
            #line 96 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
, Tuple.Create(Tuple.Create(" ", 5198), Tuple.Create<System.Object, System.Int32>(icons[_idx++]
            
            #line default
            #line hidden
, 5199), false)
);

WriteLiteral(" style=\"font-size:20px;\"");

WriteLiteral("><span></span></i>\r\n");

            
            #line 97 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"kt-menu__link-text  pl-2\"");

WriteLiteral(" style=\"font-size:16px;\"");

WriteLiteral(">");

            
            #line 98 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                                                                                      Write(menu.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n                    </li>\r\n");

            
            #line 101 "..\..\Views\Shared\_Nav_AsideMenu.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
