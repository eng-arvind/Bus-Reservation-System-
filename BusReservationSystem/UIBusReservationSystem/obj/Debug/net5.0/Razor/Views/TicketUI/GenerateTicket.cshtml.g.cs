#pragma checksum "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6372702897d56154d72908fb897ec4f25b4fdeb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TicketUI_GenerateTicket), @"mvc.1.0.view", @"/Views/TicketUI/GenerateTicket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6372702897d56154d72908fb897ec4f25b4fdeb5", @"/Views/TicketUI/GenerateTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940633eda7b70c4603a7a64d9d49224ee88351b0", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketUI_GenerateTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px;height:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:1px solid black;width:30%;height:30%;margin-left:34%;margin-top:5%;padding:20px;background-color:blanchedalmond;font-size:15px; text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div>\r\n");
#nullable restore
#line 2 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
     if (ViewData["User"] as BusReservationSystem.Models.UserReg != null)
    {
        BusReservationSystem.Models.UserReg user = ViewData["User"] as BusReservationSystem.Models.UserReg;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color:firebrick;margin-bottom:0px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6372702897d56154d72908fb897ec4f25b4fdeb55604", async() => {
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
                <ul class=""na");
            WriteLiteral("vbar-nav navbar-right\" style=\"color:white;float:right\">\r\n                    <li style=\"margin: 10px; font-size: 15px\"><span class=\"glyphicon glyphicon-user\"></span>Hi, ");
#nullable restore
#line 24 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
                                                                                                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1685, "\"", 1722, 1);
#nullable restore
#line 25 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
WriteAttributeValue("", 1692, Url.Action("HomePage","Home"), 1692, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span>SignOut</a></li>\r\n                    <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1874, "\"", 1923, 1);
#nullable restore
#line 26 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
WriteAttributeValue("", 1881, Url.Action("DashBoard","AuthUserUI",user), 1881, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span>DashBoard</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n");
#nullable restore
#line 30 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color:firebrick;margin-bottom:0px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6372702897d56154d72908fb897ec4f25b4fdeb59988", async() => {
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
                <ul class=""na");
            WriteLiteral("vbar-nav navbar-right\" style=\"color:white;float:right\">\r\n                    <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 3429, "\"", 3476, 1);
#nullable restore
#line 52 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
WriteAttributeValue("", 3436, Url.Action("RegisterPage", "UserRegUI"), 3436, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-user\"></span> Sign Up</a></li>\r\n                    <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 3627, "\"", 3668, 1);
#nullable restore
#line 53 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
WriteAttributeValue("", 3634, Url.Action("Login", "AuthUserUI"), 3634, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span> Login</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n");
#nullable restore
#line 57 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6372702897d56154d72908fb897ec4f25b4fdeb513743", async() => {
                WriteLiteral(@"
        <table border=""1"">
            <tr>
                <th>Email Id</th>
                <th>Mobile number</th>
                <th>From</th>
                <th>To</th>
                <th>Date and time</th>
                <th>Bus Name</th>
                <th>Amount Paid</th>
                <th>Book Status</th>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 72 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["Email"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["Mob"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 74 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["From"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 75 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["To"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 76 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["Date"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 77 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["BusName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 78 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["amt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 79 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\GenerateTicket.cshtml"
               Write(ViewData["Status"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
