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
    
    #line 6 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Menu/_ListTree_Data.cshtml")]
    public partial class _Areas_Admin_Views_Menu__ListTree_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.Menu>>
    {
        public _Areas_Admin_Views_Menu__ListTree_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var enableSelect = this.EnableSelect();
    //var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"kt-widget4\"");

WriteLiteral(" style=\"overflow-x:auto;\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"table table-striped table-bordered table-hover table-checkable kt-datatab" +
"le__table table-sm \"");

WriteLiteral(">\r\n        <thead>\r\n            <tr");

WriteLiteral(" class=\"kt-datatable__row\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"kt-datatable__cell--center kt-datatable__cell kt-datatable__cell--check\"");

WriteLiteral(" style=\"width:20px;\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"kt-checkbox kt-checkbox--single kt-checkbox--all kt-checkbox--solid\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" />\r\n                            <span></span>\r\n                        </label>\r" +
"\n                    </th>\r\n");

            
            #line 29 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }
                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-left\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1359), Tuple.Create("\"", 1408)
            
            #line 31 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("TreeNodeName"))
            
            #line default
            #line hidden
, 1366), false)
);

WriteLiteral(">节点名</a></th>\r\n                <th");

WriteLiteral(" class=\"text-left\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1464), Tuple.Create("\"", 1512)
            
            #line 32 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1471), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("DisplayName"))
            
            #line default
            #line hidden
, 1471), false)
);

WriteLiteral(">显示名</a></th>\r\n                <th");

WriteLiteral(" class=\"text-left\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1568), Tuple.Create("\"", 1608)
            
            #line 33 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1575), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Url"))
            
            #line default
            #line hidden
, 1575), false)
);

WriteLiteral(">链接</a></th>\r\n                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1664), Tuple.Create("\"", 1705)
            
            #line 34 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1671), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Sort"))
            
            #line default
            #line hidden
, 1671), false)
);

WriteLiteral(">排序</a></th>\r\n                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1762), Tuple.Create("\"", 1806)
            
            #line 35 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1769), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Visible"))
            
            #line default
            #line hidden
, 1769), false)
);

WriteLiteral(">可见</a></th>\r\n                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"必要。必要的菜单，必须至少有角色拥有这些权限，如果没有则自动授权给系统角色\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1909), Tuple.Create("\"", 1955)
            
            #line 36 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               , Tuple.Create(Tuple.Create("", 1916), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Necessary"))
            
            #line default
            #line hidden
, 1916), false)
);

WriteLiteral(">必要</a></th>\r\n                <th");

WriteLiteral(" class=\"text-left\"");

WriteLiteral(" title=\"权限子项。逗号分隔，每个权限子项名值竖线分隔\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2041), Tuple.Create("\"", 2088)
            
            #line 37 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2048), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Permission"))
            
            #line default
            #line hidden
, 2048), false)
);

WriteLiteral(">权限子项</a></th>\r\n");

            
            #line 38 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 38 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">升</th>\r\n");

WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">降</th>\r\n");

WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 43 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");

            
            #line 47 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
             foreach (var entity in Model)
            {
                var permission = entity.Permission + "";
                var p = entity.Parent as IEntityTree;
                if (p == null)
                {
                    p = fact.EntityType.GetValue("Root") as IEntityTree;
                }
                var id = entity.ID;

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n");

            
            #line 57 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 57 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                     if (enableSelect)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:20px;\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"kt-checkbox kt-checkbox--single kt-checkbox--all kt-checkbox--solid\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3121), Tuple.Create("\"", 3139)
            
            #line 61 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3129), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 3129), false)
);

WriteLiteral(" />\r\n                                <span></span>\r\n                            <" +
"/label>\r\n                        </td>\r\n");

            
            #line 65 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                    }
                    
            
            #line default
            #line hidden
            
            #line 66 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                                                                             

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral(">");

            
            #line 67 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                     Write(entity.TreeNodeName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral(">");

            
            #line 68 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                     Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral(">");

            
            #line 69 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                     Write(entity.Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 70 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                      Write(entity.Sort.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                        <span>\r\n                            <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3761), Tuple.Create("\"", 3812)
, Tuple.Create(Tuple.Create("", 3769), Tuple.Create("la", 3769), true)
, Tuple.Create(Tuple.Create(" ", 3771), Tuple.Create("la-", 3772), true)
            
            #line 73 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3775), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "check" : "close"
            
            #line default
            #line hidden
, 3775), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 3813), Tuple.Create("\"", 3864)
, Tuple.Create(Tuple.Create("", 3821), Tuple.Create("color:", 3821), true)
            
            #line 73 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 , Tuple.Create(Tuple.Create(" ", 3827), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "green" : "red"
            
            #line default
            #line hidden
, 3828), false)
, Tuple.Create(Tuple.Create("", 3863), Tuple.Create(";", 3863), true)
);

WriteLiteral("></i>\r\n                        </span>\r\n                    </td>\r\n              " +
"      <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                        <span>\r\n                            <i");

WriteAttribute("class", Tuple.Create(" class=\"", 4040), Tuple.Create("\"", 4093)
, Tuple.Create(Tuple.Create("", 4048), Tuple.Create("la", 4048), true)
, Tuple.Create(Tuple.Create(" ", 4050), Tuple.Create("la-", 4051), true)
            
            #line 78 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 4054), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "check" : "close"
            
            #line default
            #line hidden
, 4054), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 4094), Tuple.Create("\"", 4147)
, Tuple.Create(Tuple.Create("", 4102), Tuple.Create("color:", 4102), true)
            
            #line 78 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                   , Tuple.Create(Tuple.Create(" ", 4108), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "green" : "red"
            
            #line default
            #line hidden
, 4109), false)
, Tuple.Create(Tuple.Create("", 4146), Tuple.Create(";", 4146), true)
);

WriteLiteral("></i>\r\n                        </span>\r\n                    </td>\r\n              " +
"      <td");

WriteAttribute("title", Tuple.Create(" title=\"", 4238), Tuple.Create("\"", 4257)
            
            #line 81 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 4246), Tuple.Create<System.Object, System.Int32>(permission
            
            #line default
            #line hidden
, 4246), false)
);

WriteLiteral(">");

            
            #line 81 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                        Write(permission.Length > 35 ? permission.Substring(0, 25) + "......" : permission);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 82 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 82 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                     if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:50px;\"");

WriteLiteral(">\r\n");

            
            #line 85 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 85 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                             if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[0])
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4699), Tuple.Create("\"", 4735)
            
            #line 87 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 4706), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id })
            
            #line default
            #line hidden
, 4706), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"la la-angle-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 88 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n");

WriteLiteral("                        <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:50px;\"");

WriteLiteral(">\r\n");

            
            #line 91 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 91 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                             if (p != null && entity != p.Childs[p.Childs.Count - 1])
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5085), Tuple.Create("\"", 5123)
            
            #line 93 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 5092), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id })
            
            #line default
            #line hidden
, 5092), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"la la-angle-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 94 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n");

WriteLiteral("                        <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(" style=\"width: 90px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 97 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                       Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n");

            
            #line 99 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n");

            
            #line 101 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
