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
    
    #line 1 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 3 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Toolbar_Adv.cshtml")]
    public partial class _Views_Shared__List_Toolbar_Adv_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Toolbar_Adv_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!--工具-->\r\n<div");

WriteLiteral(" class=\"kt-section__content pull-right\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(" aria-label=\"Button group with nested dropdown\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 298), Tuple.Create("\"", 331)
            
            #line 10 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 305), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportExcel")
            
            #line default
            #line hidden
, 305), false)
);

WriteLiteral(" class=\"btn btn-sm btn-secondary \"");

WriteLiteral(" title=\"导出Excel文件\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file-excel text-success\"");

WriteLiteral("></i></a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 446), Tuple.Create("\"", 477)
            
            #line 11 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 453), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportXml")
            
            #line default
            #line hidden
, 453), false)
);

WriteLiteral(" class=\"btn btn-sm btn-secondary\"");

WriteLiteral(" title=\"导出Xml文件\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file-code text-danger\"");

WriteLiteral("></i></a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 587), Tuple.Create("\"", 619)
            
            #line 12 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 594), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportJson")
            
            #line default
            #line hidden
, 594), false)
);

WriteLiteral(" class=\"btn btn-sm btn-secondary\"");

WriteLiteral(" title=\"导出为Json对象\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file-alt\"");

WriteLiteral("></i></a>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"dropdown dropdown-inline p\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-outline-brand btn-elevate-hover btn-icon btn-sm btn-icon-md \"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"flaticon-more-1\"");

WriteLiteral("></i>\r\n        </button>\r\n        <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" x-placement=\"bottom-end\"");

WriteLiteral(" style=\"position: absolute; will-change: transform; top: 0px; left: 0px; transfor" +
"m: translate3d(30px, 30px, 0px);\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
             if (this.Has(PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item text-warning\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1321), Tuple.Create("\"", 1355)
            
            #line 21 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteSelect")
            
            #line default
            #line hidden
, 1328), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" data-confirm=\"该操作将删除选中数据并不可恢复！确认删除？\"");

WriteLiteral(" title=\"删除选中数据\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-check-square text-warning\"");

WriteLiteral("></i> 删除选中</a>\r\n");

WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item text-danger\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1559), Tuple.Create("\"", 1590)
            
            #line 22 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1566), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteAll")
            
            #line default
            #line hidden
, 1566), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"该操作将删除当前查询的所有数据并不可恢复！确认删除？\"");

WriteLiteral(" title=\"删除当前查询的所有数据\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-list-alt text-danger\"");

WriteLiteral("></i> 删除全部</a>\r\n");

            
            #line 23 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 24 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
             if (SysConfig.Current.Develop)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"dropdown-divider\"");

WriteLiteral("></div>\r\n");

WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1897), Tuple.Create("\"", 1927)
            
            #line 27 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1904), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeList")
            
            #line default
            #line hidden
, 1904), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"la la-plus\"");

WriteLiteral("></i> 生成列表</a>\r\n");

WriteLiteral("                <a");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2006), Tuple.Create("\"", 2036)
            
            #line 28 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 2013), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeForm")
            
            #line default
            #line hidden
, 2013), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"la la-user\"");

WriteLiteral("></i> 生成表单</a>\r\n");

            
            #line 29 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral(@"        </div>
    </div>
</div>

<script>
    if (sessionStorage.state) {
        $(""#toggleBar"").html(""隐藏自定义搜索框"");
        $("".bars"").removeClass(""kt-hidden"");
    }
    $(""#toggleBar"").click(function () {
        if (!sessionStorage.state) {
            $(this).html(""隐藏自定义搜索框"");
            $("".bars"").removeClass(""kt-hidden"");
            sessionStorage.state = ""true"";
        } else {
            $(this).html(""显示自定义搜索框"");
            $("".bars"").addClass(""kt-hidden"");
            sessionStorage.removeItem(""state"");
        }
    })
</script>");

        }
    }
}
#pragma warning restore 1591
