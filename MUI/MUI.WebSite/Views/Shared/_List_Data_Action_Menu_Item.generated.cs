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
    using XCode;
    
    #line 1 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Action_Menu_Item.cshtml")]
    public partial class _Views_Shared__List_Data_Action_Menu_Item_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Action_Menu_Item_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
  
    var entity = Model as IEntity;

    var rv = entity.GetRouteKey();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!--双击打开添加样式 .editcell 即可-->\r\n");

            
            #line 9 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
 if (this.Has(PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" title=\"编辑\"");

WriteLiteral(" class=\"dropdown-item editcell\"");

WriteAttribute("href", Tuple.Create(" href=\"", 229), Tuple.Create("\"", 259)
            
            #line 11 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
, Tuple.Create(Tuple.Create("", 236), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", rv)
            
            #line default
            #line hidden
, 236), false)
);

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"flaticon2-edit text-primary\"");

WriteLiteral("></i>编辑\r\n    </a>\r\n");

            
            #line 14 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
}
else if (this.Has(PermissionFlags.Detail))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" title=\"查看\"");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 417), Tuple.Create("\"", 449)
            
            #line 17 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
, Tuple.Create(Tuple.Create("", 424), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", rv)
            
            #line default
            #line hidden
, 424), false)
);

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"flaticon2-document text-primary\"");

WriteLiteral("></i>查看\r\n    </a>\r\n");

            
            #line 20 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
}

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
 if (this.Has(PermissionFlags.Delete))
{
    var fact = ViewBag.Factory as IEntityOperate;
    var fi = (fact == null || fact.Fields == null) ? null : fact.Fields.FirstOrDefault(e => e.Name.EqualIgnoreCase("Deleted", "IsDelete", "IsDeleted"));
    if (fi != null && fi.Type == typeof(Boolean) && (Boolean)entity[fi.Name])
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" title=\"恢复\"");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 902), Tuple.Create("\"", 934)
            
            #line 27 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
, Tuple.Create(Tuple.Create("", 909), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 909), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"确认恢复？\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"flaticon-reply text-warning\"");

WriteLiteral("></i>恢复\r\n        </a>\r\n");

            
            #line 30 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" title=\"删除\"");

WriteLiteral(" class=\"dropdown-item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1120), Tuple.Create("\"", 1152)
            
            #line 33 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
, Tuple.Create(Tuple.Create("", 1127), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 1127), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"确认删除？\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"flaticon-delete text-danger\"");

WriteLiteral("></i> 删除\r\n        </a>\r\n");

            
            #line 36 "..\..\Views\Shared\_List_Data_Action_Menu_Item.cshtml"
    }
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
