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
    
    #line 1 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Stat.cshtml")]
    public partial class _Views_Shared__List_Data_Stat_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Stat_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_List_Data_Stat.cshtml"
  
    var entity = Model as IEntity;

    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var enableSelect = this.EnableSelect();

            
            #line default
            #line hidden
WriteLiteral("\r\n<tr>\r\n");

            
            #line 13 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\_List_Data_Stat.cshtml"
     if (enableSelect)
    {

            
            #line default
            #line hidden
WriteLiteral("        <td></td>\r\n");

            
            #line 16 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 17 "..\..\Views\Shared\_List_Data_Stat.cshtml"
     foreach (var item in fields)
    {
        if (item.IsIdentity)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">总计</td>\r\n");

            
            #line 22 "..\..\Views\Shared\_List_Data_Stat.cshtml"
        }
        else
        {
            var value = entity[item.Name];
            switch (Type.GetTypeCode(item.Type))
            {
                case TypeCode.Boolean:
                case TypeCode.DateTime:

            
            #line default
            #line hidden
WriteLiteral("                    <td></td>\r\n");

            
            #line 31 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    break;
                case TypeCode.Decimal:

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                                      Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 34 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    break;
                case TypeCode.Single:
                case TypeCode.Double:

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                                      Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 38 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    break;
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    //特殊处理枚举
                    if (item.Type.IsEnum)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral("></td>\r\n");

            
            #line 50 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    }
                    else if (item.Name.EqualIgnoreCase("CreateUserID", "UpdateUserID"))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral("></td>\r\n");

            
            #line 54 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral(">");

            
            #line 57 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                                         Write(Convert.ToInt64(value).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 58 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    }
                    break;
                case TypeCode.String:
                default:

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-left\"");

WriteLiteral("></td>\r\n");

            
            #line 63 "..\..\Views\Shared\_List_Data_Stat.cshtml"
                    break;
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 67 "..\..\Views\Shared\_List_Data_Stat.cshtml"
     if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
    {

            
            #line default
            #line hidden
WriteLiteral("        <td></td>\r\n");

            
            #line 70 "..\..\Views\Shared\_List_Data_Stat.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</tr>");

        }
    }
}
#pragma warning restore 1591
