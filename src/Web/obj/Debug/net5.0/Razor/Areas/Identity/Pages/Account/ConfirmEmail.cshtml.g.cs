#pragma checksum "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80781eb18679f88d29060ccf632134b2338265b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FarmFresh.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
namespace FarmFresh.Web.Areas.Identity.Pages.Account
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
#line 1 "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\_ViewImports.cshtml"
using FarmFresh.Web.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\_ViewImports.cshtml"
using FarmFresh.Infrastructure.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using FarmFresh.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80781eb18679f88d29060ccf632134b2338265b", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3e6b7c18337fddcfad6de35d1f6bc3b51cfed6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64641d6fa4ed1fb3bf885440ad32cd5f77b01d2a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 7 "C:\HAULIO\FarmFresh2\src\Web\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<div>\n    <p>\n        Thank you for confirming your email.\n    </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591