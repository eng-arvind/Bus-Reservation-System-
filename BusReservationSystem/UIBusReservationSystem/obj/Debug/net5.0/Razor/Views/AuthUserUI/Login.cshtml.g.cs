#pragma checksum "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049d25453ce5c243dc67fdeebe19885b1785c033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuthUserUI_Login), @"mvc.1.0.view", @"/Views/AuthUserUI/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049d25453ce5c243dc67fdeebe19885b1785c033", @"/Views/AuthUserUI/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940633eda7b70c4603a7a64d9d49224ee88351b0", @"/Views/_ViewImports.cshtml")]
    public class Views_AuthUserUI_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Login.cshtml"
 using(Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>UserEmail</td>\r\n            <td>");
#nullable restore
#line 6 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Login.cshtml"
           Write(Html.TextBox("UserEmail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Password</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Login.cshtml"
           Write(Html.TextBox("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><input type=\"submit\" /></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 16 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Login.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Karthik.ks\Desktop\BusResSys\BusReservationSystem\UIBusReservationSystem\Views\AuthUserUI\Login.cshtml"
                             
}

#line default
#line hidden
#nullable disable
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
