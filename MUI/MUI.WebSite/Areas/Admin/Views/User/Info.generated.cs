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
    
    #line 2 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Net;
    
    #line 3 "..\..\Areas\Admin\Views\User\Info.cshtml"
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
    
    #line 6 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using NewLife.Cube.Entity;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 4 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/Info.cshtml")]
    public partial class _Areas_Admin_Views_User_Info_cshtml : System.Web.Mvc.WebViewPage<XCode.Membership.IUser>
    {
        public _Areas_Admin_Views_User_Info_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Areas\Admin\Views\User\Info.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;
    var fact = EntityFactory.CreateOperate(ViewData.ModelMetadata.ModelType);
    var user = Model as IUser;

    var ms = NewLife.Web.OAuthConfig.Current.Items.Where(e => !e.AppID.IsNullOrEmpty()).ToList();
    var binds = ViewBag.Binds as IList<UserConnect>;


            
            #line default
            #line hidden
WriteLiteral("\r\n<!--帐号信息-->\r\n<div");

WriteLiteral(" class=\"kt-portlet\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-widget kt-widget--user-profile-3\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"kt-widget__top\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"kt-widget__pic kt-widget__pic--success kt-font-danger kt-font-bolder kt-f" +
"ont-light\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Areas\Admin\Views\User\Info.cshtml"
               Write(user.Name.Substring(0, 1).ToUpper());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"kt-widget__content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"kt-widget__head\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"kt-widget__user\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"kt-widget__username\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 28 "..\..\Areas\Admin\Views\User\Info.cshtml"
                           Write(user.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n                            <span");

WriteLiteral(" class=\"kt-badge kt-badge--bolder kt-badge kt-badge--inline kt-badge--unified-suc" +
"cess\"");

WriteLiteral(">");

            
            #line 30 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                                                                                    Write(user.Roles.Join(",", r => r + ""));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"kt-widget__action\"");

WriteLiteral(">\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"kt-widget__subhead\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"flaticon2-calendar-3\"");

WriteLiteral("></i>");

            
            #line 38 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                                   Write(user.Logins);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"flaticon2-placeholder\"");

WriteLiteral("></i>");

            
            #line 39 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                                    Write(user.LastLogin);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"flaticon2-placeholder\"");

WriteLiteral("></i>");

            
            #line 40 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                                    Write(user.LastLoginIP);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"kt-widget__subhead\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"flaticon2-new-email\"");

WriteLiteral("></i>");

            
            #line 43 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                                  Write(user.Mail);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r" +
"\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!--帐号修改内容-->\r\n<div");

WriteLiteral(" class=\"kt-portlet kt-portlet--tabs\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__head\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet__head-toolbar\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"nav nav-tabs nav-tabs-space-lg nav-tabs-line nav-tabs-bold nav-tabs-line-" +
"3x nav-tabs-line-brand\"");

WriteLiteral(" role=\"tablist\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"nav-link active\"");

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(" href=\"#kt_apps_contacts_view_tab_1\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"flaticon2-note\"");

WriteLiteral("></i> 基本信息\r\n                    </a>\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"nav-link\"");

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(" href=\"#kt_apps_contacts_view_tab_2\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"flaticon2-calendar-3\"");

WriteLiteral("></i> 扩展信息\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n " +
"       </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"kt-portlet__body\"");

WriteLiteral(">\r\n");

            
            #line 72 "..\..\Areas\Admin\Views\User\Info.cshtml"
        
            
            #line default
            #line hidden
            
            #line 72 "..\..\Areas\Admin\Views\User\Info.cshtml"
         if (ViewBag.StatusMessage != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-success alert-dismissible text-center\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"alert\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                <strong>");

            
            #line 76 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n            </div>\r\n");

            
            #line 78 "..\..\Areas\Admin\Views\User\Info.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 79 "..\..\Areas\Admin\Views\User\Info.cshtml"
         using (Html.BeginForm("Info", null, new { id = Model[fact.Unique.Name] }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"tab-content  kt-margin-t-20\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"tab-pane active\"");

WriteLiteral(" id=\"kt_apps_contacts_view_tab_1\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"kt-form__body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"kt-section kt-section--first\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"kt-section__body\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">名称</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4077), Tuple.Create("\"", 4095)
            
            #line 90 "..\..\Areas\Admin\Views\User\Info.cshtml"
       , Tuple.Create(Tuple.Create("", 4085), Tuple.Create<System.Object, System.Int32>(user.Name
            
            #line default
            #line hidden
, 4085), false)
);

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(">\r\n                                    </div>\r\n                                </" +
"div>\r\n                                <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">密码</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"Password\"");

WriteLiteral(" name=\"Password\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4539), Tuple.Create("\"", 4561)
            
            #line 96 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                         , Tuple.Create(Tuple.Create("", 4547), Tuple.Create<System.Object, System.Int32>(user.Password
            
            #line default
            #line hidden
, 4547), false)
);

WriteLiteral(">\r\n                                    </div>\r\n                                </" +
"div>\r\n                                <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">显示名</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"DisplayName\"");

WriteLiteral(" name=\"DisplayName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4988), Tuple.Create("\"", 5013)
            
            #line 102 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                           , Tuple.Create(Tuple.Create("", 4996), Tuple.Create<System.Object, System.Int32>(user.DisplayName
            
            #line default
            #line hidden
, 4996), false)
);

WriteLiteral(">\r\n                                    </div>\r\n                                </" +
"div>\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">性别</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"Sex\"");

WriteLiteral(" name=\"Sex\"");

WriteLiteral(">\r\n                                            <option");

WriteLiteral(" value=\"0\"");

WriteLiteral(" ");

            
            #line 109 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                          Write(user.Sex == SexKinds.未知 ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">未知</option>\r\n                                            <option");

WriteLiteral(" value=\"1\"");

WriteLiteral(" ");

            
            #line 110 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                          Write(user.Sex == SexKinds.男 ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">男</option>\r\n                                            <option");

WriteLiteral(" value=\"2\"");

WriteLiteral(" ");

            
            #line 111 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                                          Write(user.Sex == SexKinds.女 ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(@">女</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

                <div");

WriteLiteral(" class=\"tab-pane \"");

WriteLiteral(" id=\"kt_apps_contacts_view_tab_2\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"kt-form__body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"kt-section kt-section--first\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"kt-section__body\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">邮件</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Mail\"");

WriteLiteral(" name=\"Mail\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6610), Tuple.Create("\"", 6628)
            
            #line 128 "..\..\Areas\Admin\Views\User\Info.cshtml"
                             , Tuple.Create(Tuple.Create("", 6618), Tuple.Create<System.Object, System.Int32>(user.Mail
            
            #line default
            #line hidden
, 6618), false)
);

WriteLiteral(">\r\n                                    </div>\r\n                                </" +
"div>\r\n                                <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">手机</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Mobile\"");

WriteLiteral(" name=\"Mobile\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7044), Tuple.Create("\"", 7064)
            
            #line 134 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                 , Tuple.Create(Tuple.Create("", 7052), Tuple.Create<System.Object, System.Int32>(user.Mobile
            
            #line default
            #line hidden
, 7052), false)
);

WriteLiteral(">\r\n                                    </div>\r\n                                </" +
"div>\r\n                                <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">代码</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Code\"");

WriteLiteral(" name=\"Code\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7476), Tuple.Create("\"", 7494)
            
            #line 140 "..\..\Areas\Admin\Views\User\Info.cshtml"
                             , Tuple.Create(Tuple.Create("", 7484), Tuple.Create<System.Object, System.Int32>(user.Code
            
            #line default
            #line hidden
, 7484), false)
);

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"form-text text-muted\"");

WriteLiteral(">身份证、员工编号等</span>\r\n\r\n                                    </div>\r\n                " +
"                </div>\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-xl-3 col-lg-3 text-right\"");

WriteLiteral(">第三方绑定</label>\r\n                                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n\r\n");

            
            #line 149 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 149 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                         foreach (var mi in ms)
                                        {
                                            var uc = binds.FirstOrDefault(e => e.Enable && e.Provider.EqualIgnoreCase(mi.Name));
                                            if (uc != null)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 8327), Tuple.Create("\"", 8348)
            
            #line 154 "..\..\Areas\Admin\Views\User\Info.cshtml"
               , Tuple.Create(Tuple.Create("", 8335), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 8335), false)
, Tuple.Create(Tuple.Create("", 8343), Tuple.Create("（已绑定）", 8343), true)
);

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                <br />\r\n");

WriteLiteral("                                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8478), Tuple.Create("\"", 8506)
, Tuple.Create(Tuple.Create("", 8485), Tuple.Create<System.Object, System.Int32>(Href("~/Sso/UnBind/")
, 8485), false)
            
            #line 156 "..\..\Areas\Admin\Views\User\Info.cshtml"
, Tuple.Create(Tuple.Create("", 8498), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 8498), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 8507), Tuple.Create("\"", 8528)
, Tuple.Create(Tuple.Create("", 8515), Tuple.Create("取消绑定", 8515), true)
            
            #line 156 "..\..\Areas\Admin\Views\User\Info.cshtml"
           , Tuple.Create(Tuple.Create(" ", 8519), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 8520), false)
);

WriteLiteral(" class=\"btn btn-outline-brand btn-sm\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user-minus\"");

WriteLiteral("></i>取消绑定</a>\r\n");

            
            #line 157 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 8840), Tuple.Create("\"", 8861)
            
            #line 160 "..\..\Areas\Admin\Views\User\Info.cshtml"
               , Tuple.Create(Tuple.Create("", 8848), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 8848), false)
, Tuple.Create(Tuple.Create("", 8856), Tuple.Create("（未绑定）", 8856), true)
);

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                <br />\r\n");

WriteLiteral("                                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8991), Tuple.Create("\"", 9017)
, Tuple.Create(Tuple.Create("", 8998), Tuple.Create<System.Object, System.Int32>(Href("~/Sso/Bind/")
, 8998), false)
            
            #line 162 "..\..\Areas\Admin\Views\User\Info.cshtml"
, Tuple.Create(Tuple.Create("", 9009), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 9009), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 9018), Tuple.Create("\"", 9037)
, Tuple.Create(Tuple.Create("", 9026), Tuple.Create("绑定", 9026), true)
            
            #line 162 "..\..\Areas\Admin\Views\User\Info.cshtml"
       , Tuple.Create(Tuple.Create(" ", 9028), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 9029), false)
);

WriteLiteral(" class=\"btn btn-outline-brand btn-sm\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user-plus\"");

WriteLiteral("></i>去绑定</a>\r\n");

            
            #line 163 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                            }
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </div>\r\n                                </div" +
">\r\n                            </div>\r\n                        </div>\r\n         " +
"           </div>\r\n                </div>\r\n\r\n            </div>\r\n");

            
            #line 173 "..\..\Areas\Admin\Views\User\Info.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"kt-separator kt-separator--space-lg kt-separator--fit kt-separator--borde" +
"r-solid\"");

WriteLiteral("></div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"kt-form__actions\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xl-3\"");

WriteLiteral("></div>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-xl-6\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-save\"");

WriteLiteral("></i><strong>保存</strong></button>\r\n                    </div>\r\n                </" +
"div>\r\n            </div>\r\n");

            
            #line 183 "..\..\Areas\Admin\Views\User\Info.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n    <!--End:: Portlet-->\r\n</div>\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
