#pragma checksum "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3ec15c188b3808224122a55501d3f6dc9b9c803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuthUserUI_Profile), @"mvc.1.0.view", @"/Views/AuthUserUI/Profile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\_ViewImports.cshtml"
using UIBusReservationSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\_ViewImports.cshtml"
using UIBusReservationSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ec15c188b3808224122a55501d3f6dc9b9c803", @"/Views/AuthUserUI/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940633eda7b70c4603a7a64d9d49224ee88351b0", @"/Views/_ViewImports.cshtml")]
    public class Views_AuthUserUI_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusReservationSystem.Models.UserReg>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px;height:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:1px solid black;width:30%;height:30%;margin-left:34%;margin-top:10%;padding:20px;background-color:blanchedalmond;font-size:15px; text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color:firebrick;margin-bottom:0px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3ec15c188b3808224122a55501d3f6dc9b9c8035179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <a style=""font-size:30px;font-weight:bold;color:white"" class=""navbar-brand"" href=""#"">Global Bus Seva</a>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"" style=""font-size:20px;font-weight:bold"">
                    <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                </li>
                <li style=""font-size:15px"" class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">About</a>
                </li>
                <li style=""font-size:15px"" class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">Terms of Use</a>
                </li>
                <li style=""font-size:15px"" class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">Contact Us</a>
                </li>
                <li>Hi, ");
#nullable restore
#line 20 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <ul class=\"navbar-nav navbar-right\" style=\"color:white;float:right\">\r\n                <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1417, 1);
#nullable restore
#line 23 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 1378, Url.Action("RegisterPage","UserRegUI"), 1378, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-user\"></span> Sign Up</a></li>\r\n                <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1564, "\"", 1601, 1);
#nullable restore
#line 24 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 1571, Url.Action("HomePage","Home"), 1571, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span>SignOut</a></li>\r\n                <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1749, "\"", 1790, 1);
#nullable restore
#line 25 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 1756, Url.Action("AdminHome","AdminUI"), 1756, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span> Admin Login</a></li>\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3ec15c188b3808224122a55501d3f6dc9b9c8039443", async() => {
                WriteLiteral("\r\n        <label>First Name</label>\r\n        <br />\r\n        <input type=\"text\"");
                BeginWriteAttribute("value", " value=", 2175, "", 2198, 1);
#nullable restore
#line 32 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 2182, Model.FirstName, 2182, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Firstname\" />\r\n        <br />\r\n        <label>Last Name</label>\r\n        <br />\r\n        <input type=\"text\" name=\"Secondname\"");
                BeginWriteAttribute("value", " value=", 2330, "", 2352, 1);
#nullable restore
#line 36 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 2337, Model.LastName, 2337, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br />\r\n        <label>Email</label>\r\n        <br />\r\n        <input type=\"email\" name=\"Useremail\" placeholder=\"Email\"");
                BeginWriteAttribute("value", " value=", 2483, "", 2506, 1);
#nullable restore
#line 40 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 2490, Model.UserEmail, 2490, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br />\r\n        <label>Mobile</label>\r\n        <br />\r\n        <input type=\"text\" name=\"Mobile\" placeholder=\"Mobile\"");
                BeginWriteAttribute("value", " value=", 2635, "", 2656, 1);
#nullable restore
#line 44 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 2642, Model.UserMob, 2642, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br />\r\n        <label>Address</label>\r\n        <br />\r\n        <input type=\"text\" name=\"Address\" placeholder=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 2788, "\"", 2813, 1);
#nullable restore
#line 48 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Profile.cshtml"
WriteAttributeValue("", 2796, Model.UsrAddress, 2796, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br />\r\n        <br />\r\n        <input type=\"submit\" name=\"EditProfile\" />\r\n\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <footer style=""position:absolute;bottom:1px;width:100%;height:50px;background-color:darkgrey"">

            <div class=""footer-copyright text-center py-3"">
                © 2020 Copyright:
                <a href=""https://globallogic.com/""> GlobalBusSeva.com</a>
            </div>
        </footer>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusReservationSystem.Models.UserReg> Html { get; private set; }
    }
}
#pragma warning restore 1591