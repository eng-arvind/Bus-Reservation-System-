#pragma checksum "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e627d21e0f190527fa0a9a449c8fbe94e19c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUI_DeleteRoute), @"mvc.1.0.view", @"/Views/AdminUI/DeleteRoute.cshtml")]
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
#line 1 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\_ViewImports.cshtml"
using UIBusReservationSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\_ViewImports.cshtml"
using UIBusReservationSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e627d21e0f190527fa0a9a449c8fbe94e19c37", @"/Views/AdminUI/DeleteRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940633eda7b70c4603a7a64d9d49224ee88351b0", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUI_DeleteRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusReservationSystem.Models.Route>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px;height:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color:firebrick;margin-bottom:0px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9e627d21e0f190527fa0a9a449c8fbe94e19c374145", async() => {
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
            </ul>
            <ul class=""navbar-nav navbar-right"" style=""color:white;float:right"">
           ");
            WriteLiteral("     <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1323, "\"", 1369, 1);
#nullable restore
#line 22 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
WriteAttributeValue("", 1330, Url.Action("AdminDashboard","AdminUI"), 1330, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-refresh\"></span> Refresh</a></li>\r\n                <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1519, "\"", 1560, 1);
#nullable restore
#line 23 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
WriteAttributeValue("", 1526, Url.Action("AdminHome","AdminUI"), 1526, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-off\"></span> Logout</a></li>\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n    <div style=\"margin-top:5%;margin-left:40%;font-size:15px;\">\r\n");
#nullable restore
#line 28 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table border=\"1\">\r\n                <tr>\r\n                    <td>Route ID</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
                   Write(Html.TextBoxFor(x => x.RouteId, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Arrive Name</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
                   Write(Html.TextBoxFor(x => x.Arrive, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Dest Name</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
                   Write(Html.TextBoxFor(x => x.Dest, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"submit\" value=\"Delete Route\" style=\"color:white;background-color:brown\" /></td>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 48 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div>\r\n            ");
#nullable restore
#line 51 "C:\Users\arvind.vishwakarma\Desktop\FinalProject\BusReservationSystem\UIBusReservationSystem\Views\AdminUI\DeleteRoute.cshtml"
       Write(Html.ActionLink("Insert New Route", "AdminDashboard", "AdminUI"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusReservationSystem.Models.Route> Html { get; private set; }
    }
}
#pragma warning restore 1591