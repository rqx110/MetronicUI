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
    
    #line 2 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 1 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
    using System.Runtime.Versioning;
    
    #line default
    #line hidden
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 5 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/ServerVar.cshtml")]
    public partial class _Areas_Admin_Views_Index_ServerVar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index_ServerVar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    ViewBag.Title = "服务器变量列表";
    var Act = ViewBag.Act;

    var asm = Assembly.GetExecutingAssembly();
    var att = asm.GetCustomAttribute<TargetFrameworkAttribute>();
    var ver = att.FrameworkDisplayName ?? att.FrameworkName;
    var req = HttpContext.Current.Request;

            
            #line default
            #line hidden
WriteLiteral("            \r\n\r\n<div");

WriteLiteral(" class=\"kt-portlet kt-portlet--mobile\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__head\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet__head-label\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"kt-portlet__head-icon\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"la la-gear\"");

WriteLiteral("></i>\r\n                </span>\r\n                <h3");

WriteLiteral(" class=\"kt-portlet__head-title\"");

WriteLiteral(">服务器变量列表</h3>\r\n        </div>\r\n    </div>  \r\n    <div");

WriteLiteral(" class=\"kt-portlet__body\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>名称</th>\r\n                <th>数值</th>\r\n  " +
"          </tr>\r\n");

            
            #line 33 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
             foreach (var key in Request.ServerVariables.AllKeys)
            {
                var v = Request.ServerVariables[key];
                v = v.Replace("\r\n", "</br>");
                if (key.EqualIgnoreCase("HTTP_COOKIE")) { v = v.Replace(";", "</br>"); }

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");

            
            #line 39 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
                   Write(key);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 40 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
                   Write(Html.Raw(v));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 42 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n</div>     \r\n\r\n<div");

WriteLiteral(" class=\"kt-portlet kt-portlet--last kt-portlet--mobile\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__head\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet__head-label\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"kt-portlet__head-icon\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"la la-gear\"");

WriteLiteral("></i>\r\n                </span>\r\n                <h3");

WriteLiteral(" class=\"kt-portlet__head-title\"");

WriteLiteral(">Request变量列表&nbsp;&nbsp;&nbsp;&nbsp;");

            
            #line 53 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
                                                                                 Write(req.GetType().FullName);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"kt-portlet__body\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>名称</th>\r\n                <th>数值</th>\r\n  " +
"          </tr>\r\n");

            
            #line 62 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
            
            
            #line default
            #line hidden
            
            #line 62 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
             foreach (var pi in req.GetType().GetProperties())
            {
                if (pi.GetIndexParameters().Length > 0 || (pi.PropertyType != typeof(String) && pi.PropertyType != typeof(Uri))) { continue; }
                var v = req.GetValue(pi) + "";
                v = v.Replace("\r\n", "</br>");

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");

            
            #line 68 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
                   Write(pi.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 69 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
                   Write(Html.Raw(v));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 71 "..\..\Areas\Admin\Views\Index\ServerVar.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
