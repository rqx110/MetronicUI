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
    
    #line 1 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
    using System.Reflection;
    
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
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Role/SetPermission.cshtml")]
    public partial class _Areas_Admin_Views_Role_SetPermission_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Role_SetPermission_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
  
    Layout = null;

    var role = Model.Role as Role;
    var menus = Menu.Root.AllChilds;
    //var pfs = EnumHelper.GetDescriptions<PermissionFlags>().Where(e => e.Key > PermissionFlags.None);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group col-md-12\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"input-group col-md-12\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th>名称</th>\r\n  " +
"                  <th>显示名</th>\r\n                    <th>授权</th>\r\n               " +
"     <th>操作权限</th>\r\n                </tr>\r\n            </thead>\r\n            <tb" +
"ody>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                 foreach (var entity in menus)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>");

            
            #line 26 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                       Write(entity.TreeNodeName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 27 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                       Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 28 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                       Write(Html.CheckBox("p" + entity.ID, role.Has(entity.ID)));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>\r\n");

            
            #line 30 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                             if (entity.Childs.Count == 0)
                            {
                                foreach (var item in entity.Permissions.OrderBy(e => e.Key))
                                {
                                    var id = "pf" + entity.ID + "_" + ((Int32)item.Key);
                                    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                               Write(Html.CheckBox(id, role.Has(entity.ID, (PermissionFlags)item.Key)));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                                                                                                      
                                    
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                               Write(Html.Label(id, item.Value));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                                                               

            
            #line default
            #line hidden
WriteLiteral("                                    ");

WriteLiteral("&nbsp;");

WriteLiteral("\r\n");

            
            #line 38 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                                }
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                    </tr>\r\n");

            
            #line 42 "..\..\Areas\Admin\Views\Role\SetPermission.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
