#pragma checksum "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3eba980f1048c56a189a0e104fc58064502201f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TicketUI_Book), @"mvc.1.0.view", @"/Views/TicketUI/Book.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3eba980f1048c56a189a0e104fc58064502201f", @"/Views/TicketUI/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940633eda7b70c4603a7a64d9d49224ee88351b0", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketUI_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
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
#nullable restore
#line 2 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
  
    BusReservationSystem.Models.UserReg user = (BusReservationSystem.Models.UserReg)ViewData["User"];

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
     if (user.FirstName != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color:firebrick;margin-bottom:0px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3eba980f1048c56a189a0e104fc58064502201f5654", async() => {
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
#line 26 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
                                                                                                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1649, "\"", 1687, 1);
#nullable restore
#line 27 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
WriteAttributeValue("", 1656, Url.Action("HomePage", "Home"), 1656, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span>SignOut</a></li>\r\n                    <li style=\"margin: 10px; font-size: 15px\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1890, 1);
#nullable restore
#line 28 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
WriteAttributeValue("", 1846, Url.Action("DashBoard", "AuthUserUI", user), 1846, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span>DashBoard</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n");
#nullable restore
#line 32 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color:firebrick;margin-bottom:0px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3eba980f1048c56a189a0e104fc58064502201f10001", async() => {
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
            WriteLiteral(@"vbar-nav navbar-right"" style=""color:white;float:right"">
                    <li style=""margin: 10px; font-size: 15px""><a style=""color:white"" href=""#""><span class=""glyphicon glyphicon-user""></span> Sign Up</a></li>
                    <li style=""margin: 10px; font-size: 15px""><a style=""color:white"" href=""#""><span class=""glyphicon glyphicon-log-in""></span> Login</a></li>
                </ul>
            </div>
        </nav>
");
#nullable restore
#line 59 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
    }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3eba980f1048c56a189a0e104fc58064502201f12865", async() => {
                WriteLiteral("\r\n    <input hidden type\"text\" name=\"UserID\"");
                BeginWriteAttribute("value", " value=", 3924, "", 3950, 1);
#nullable restore
#line 62 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
WriteAttributeValue("", 3931, ViewData["UserID"], 3931, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <label>Schedule Id</label>\r\n    <br />\r\n    <input type=\"text\" name=\"schId\"");
                BeginWriteAttribute("value", " value=", 4034, "", 4047, 1);
#nullable restore
#line 65 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\TicketUI\Book.cshtml"
WriteAttributeValue("", 4041, Model, 4041, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly />
    <br />
    <label>First Name</label>
    <br />
    <input type=""text"" name=""Firstname"" placeholder=""FirstName"" />
    <br />
    <label>Last Name</label>
    <br />
    <input type=""text"" name=""Secondname"" placeholder=""LastName"" />
    <br />
    <label>Email</label>
    <br />
    <input type=""email"" name=""Useremail"" placeholder=""Email"" />
    <br />
    <label>Mobile</label>
    <br />
    <input type=""text"" name=""Mobile"" placeholder=""Mobile"" />
    <br />
    <label>Address</label>
    <br />
    <input type=""text"" name=""Address"" placeholder=""Address"" />
    <br />
    <label>Number of Passengers</label>
    <br />
    <input type=""number"" name=""nPassengers"" placeholder=""Total Passengers"" />
    <br />
    <label>Id Proof</label>
    <br />
    <input type=""text"" name=""Id"" placeholder=""Name-IdNum"" />
    <br />
    <br />
    <input type=""submit"" style=""background-color:darkred;color:white"" />

");
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
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591