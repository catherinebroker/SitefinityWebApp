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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.LoginForm
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/LoginForm/ForgotPassword.ForgottenPasswor" +
        "d.cshtml")]
    public partial class ForgotPassword_ForgottenPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ForgotPasswordViewModel>
    {
        public ForgotPassword_ForgottenPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 212), Tuple.Create("\"", 235)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 220), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 220), false)
);

WriteLiteral(">\n\n    <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
   Write(Html.Resource("ForgotPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
     if (Model.EmailSent)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 334), Tuple.Create("\'", 386)
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 339), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ForgotPasswordRequestSentInfo")
            
            #line default
            #line hidden
, 339), false)
);

WriteLiteral(">");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                           Write(Html.Resource("ForgotPasswordRequestSent"));

            
            #line default
            #line hidden
WriteLiteral(" <i>");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                          Write(Html.Encode(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</i></p>\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 480), Tuple.Create("\'", 539)
            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 485), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ForgotPasswordRequestSentUseLinkInfo")
            
            #line default
            #line hidden
, 485), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                  Write(Html.Resource("ForgotPasswordRequestSentUseLink"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"

        var forgottenPasswordDescription = Html.UniqueId("ForgotPasswordRequestSentInfo") + " " + Html.UniqueId("ForgotPasswordRequestSentUseLinkInfo");

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 760), Tuple.Create("\"", 786)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 767), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 767), false)
);

WriteLiteral(" class=\"btn btn-secondary\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\"", 813), Tuple.Create("\"", 861)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
   , Tuple.Create(Tuple.Create("", 832), Tuple.Create<System.Object, System.Int32>(forgottenPasswordDescription
            
            #line default
            #line hidden
, 832), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                            Write(Html.Resource("ForgotPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    }
    else
    {
        using (Html.BeginForm("SendPasswordResetEmail", "LoginForm"))
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1026), Tuple.Create("\'", 1075)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1031), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("EnterLoginEmailAddressInfo")
            
            #line default
            #line hidden
, 1031), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                            Write(Html.Resource("EnterLoginEmailAddress"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
           Write(Html.LabelFor(u => u.Email, Html.Resource("ForgotPasswordEmail")));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
           Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control", aria_describedby = Html.UniqueId("EnterLoginEmailAddressInfo") }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                      Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                     Write(Html.Resource("ForgotPasswordSendButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n");

        }
    }
}
#pragma warning restore 1591
