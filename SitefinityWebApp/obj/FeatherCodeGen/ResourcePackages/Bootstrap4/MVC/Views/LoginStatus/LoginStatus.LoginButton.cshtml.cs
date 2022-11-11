#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.LoginStatus
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginButton.cshtml")]
    public partial class LoginStatus_LoginButton : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginButton()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
  
    var SignOutUrl = string.Concat(Url.Action("SignOut"), string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 390), Tuple.Create("\"", 413)
            
            #line 11 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 398), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 398), false)
);

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"media\"");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"media-left pr-2\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"media-object\"");

WriteLiteral(">\n                <img");

WriteLiteral(" data-sf-role=\"sf-logged-in-avatar\"");

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\n            </div>\n        </div>\n        <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 755), Tuple.Create("\"", 792)
            
            #line 19 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 762), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 762), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral("></a>\n            <p");

WriteLiteral(" data-sf-role=\"sf-logged-in-email\"");

WriteLiteral("></p>\n            <a");

WriteLiteral(" class=\"btn btn-secondary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 926), Tuple.Create("\"", 944)
            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 933), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 933), false)
);

WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                       Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n        </div>\n    </div>\n\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n\n        <button");

WriteLiteral(" class=\"btn btn-secondary\"");

WriteLiteral(" data-sf-role=\"login-status-button\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                                                      Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1203), Tuple.Create("\"", 1245)
            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1210), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 1210), false)
);

WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n\n    </div>\n</div>\n\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1364), Tuple.Create("\"", 1395)
            
            #line 33 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1372), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1372), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1457), Tuple.Create("\"", 1485)
            
            #line 34 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1465), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1465), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-login-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1546), Tuple.Create("\"", 1573)
            
            #line 35 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1554), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 1554), false)
);

WriteLiteral(" />\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1637), Tuple.Create("\"", 1677)
            
            #line 36 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1645), false)
);

WriteLiteral(" />\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1744), Tuple.Create("\"", 1790)
            
            #line 37 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1752), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1752), false)
);

WriteLiteral(" />\n\n");

            
            #line 39 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
