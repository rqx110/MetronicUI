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
    
    #line 2 "..\..\Views\Shared\ObjectForm.cshtml"
    using System.ComponentModel;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Views\Shared\ObjectForm.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    
    #line 4 "..\..\Views\Shared\ObjectForm.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Shared\ObjectForm.cshtml"
    using NewLife.Reflection;
    
    #line default
    #line hidden
    using NewLife.Web;
    using XCode;
    
    #line 6 "..\..\Views\Shared\ObjectForm.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ObjectForm.cshtml")]
    public partial class _Views_Shared_ObjectForm_cshtml : System.Web.Mvc.WebViewPage<Object>
    {
        public _Views_Shared_ObjectForm_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Views\Shared\ObjectForm.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var Obj = Model as Object;
    var pis = ViewBag.Properties as IEnumerable<PropertyInfo>;
    var menu = ViewBag.Menu as IMenu;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-xl-3 col-lg-4\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet kt-portlet--height-fluid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"kt-portlet__head\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"kt-portlet__head-label\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"kt-portlet__head-icon\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"la la-cubes kt-font-primary\"");

WriteLiteral("></i>\r\n                    </span>\r\n                    <h3");

WriteLiteral(" class=\"kt-portlet__head-title\"");

WriteLiteral(">系统选项</h3>\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Shared\ObjectForm.cshtml"
       Write(Html.Partial("_Object_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-xl-9 col-lg-8\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"kt-portlet__head\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"kt-portlet__head-label\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"kt-portlet__head-icon\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"la la-gear\"");

WriteLiteral("></i>\r\n                    </span>\r\n                    <h3");

WriteLiteral(" class=\"kt-portlet__head-title\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Shared\ObjectForm.cshtml"
                                                   Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"kt-form kt-form--label-right\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"kt-portlet__body kt-padding-b-5\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Views\Shared\ObjectForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Shared\ObjectForm.cshtml"
                     using (Html.BeginForm("Update", null))
                    {
                        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Shared\ObjectForm.cshtml"
                   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Shared\ObjectForm.cshtml"
                                                
                        
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Shared\ObjectForm.cshtml"
                   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Shared\ObjectForm.cshtml"
                                                     
                        foreach (var pi in pis)
                        {
                            var name = pi.Name;
                            var dis = pi.GetDisplayName();
                            var des = pi.GetDescription();
                            if (dis.IsNullOrEmpty() && !des.IsNullOrEmpty()) { dis = des; des = null; }
                            if (!dis.IsNullOrEmpty() && des.IsNullOrEmpty() && dis.Contains("。"))
                            {
                                des = dis.Substring("。");
                                dis = dis.Substring(null, "。");
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"col-form-label col-lg-3 col-sm-12\"");

WriteAttribute("for", Tuple.Create(" for=\"", 2441), Tuple.Create("\"", 2455)
            
            #line 58 "..\..\Views\Shared\ObjectForm.cshtml"
      , Tuple.Create(Tuple.Create("", 2447), Tuple.Create<System.Object, System.Int32>(pi.Name
            
            #line default
            #line hidden
, 2447), false)
);

WriteLiteral(">");

            
            #line 58 "..\..\Views\Shared\ObjectForm.cshtml"
                                                                                            Write(dis ?? pi.Name);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <div");

WriteLiteral(" class=\"kt-margin-l-5 kt-margin-r-5 flex align-items-center\"");

WriteLiteral(" style=\"width: 18px; font-size: 1.5rem;\"");

WriteLiteral(">\r\n");

            
            #line 60 "..\..\Views\Shared\ObjectForm.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Shared\ObjectForm.cshtml"
                                     if (!des.IsNullOrEmpty())
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <i");

WriteLiteral(" class=\"la la-question-circle\"");

WriteLiteral(" data-toggle=\"kt-tooltip\"");

WriteLiteral(" data-original-title=\"");

            
            #line 62 "..\..\Views\Shared\ObjectForm.cshtml"
                                                                                                                  Write(des);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-placement=\"top\"");

WriteLiteral(" ");

WriteLiteral("></i>\r\n");

            
            #line 63 "..\..\Views\Shared\ObjectForm.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-lg-4 col-md-9 col-sm-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 66 "..\..\Views\Shared\ObjectForm.cshtml"
                               Write(Html.ForEditorX(pi.Name, Obj.GetValue(pi), pi.PropertyType, null, new { @class = "form-control" }.ToDictionary()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 67 "..\..\Views\Shared\ObjectForm.cshtml"
                               Write(Html.ValidationMessage(pi.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");

            
            #line 70 "..\..\Views\Shared\ObjectForm.cshtml"
                        }
                        if (this.Has(PermissionFlags.Update))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"kt-portlet__foot\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-group row kt-margin-b-5\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-form-label col-lg-3 col-sm-12\"");

WriteLiteral("></label>\r\n                                    <div");

WriteLiteral(" class=\"kt-margin-l-5 kt-margin-r-5 flex align-items-center\"");

WriteLiteral(" style=\"width:7px;\"");

WriteLiteral("></div>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-4 col-md-9 col-sm-12 flex align-items-center\"");

WriteLiteral(">\r\n                                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn  btn-success kt-margin-r-10\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-save\"");

WriteLiteral("></i>保存</button>\r\n                                        <button");

WriteLiteral(" type=\"reset\"");

WriteLiteral(" class=\"btn btn-secondary\"");

WriteLiteral(" onclick=\"history.go(-1)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-remove\"");

WriteLiteral("></i>返回</button>\r\n                                    </div>\r\n                   " +
"             </div>\r\n                            </div>\r\n");

            
            #line 83 "..\..\Views\Shared\ObjectForm.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r" +
"\n");

        }
    }
}
#pragma warning restore 1591
