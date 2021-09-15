#pragma checksum "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b6027edac0ea435d51ee6452845c481c2cd8a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FarmFresh.Web.Pages.Manage.Views_Manage_GenerateRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
namespace FarmFresh.Web.Pages.Manage
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
#line 1 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using FarmFresh.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using FarmFresh.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using FarmFresh.Web.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using FarmFresh.Web.ViewModels.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using FarmFresh.Web.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\HAULIO\FarmFresh2\src\Web\Views\_ViewImports.cshtml"
using FarmFresh.Infrastructure.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\_ViewImports.cshtml"
using FarmFresh.Web.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b6027edac0ea435d51ee6452845c481c2cd8a8", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2624e365d11d30f34a9d2071bc90e6202e5f005", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6998e64ac816e5ae72d1d3c57f7ee40a0ec7e098", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_GenerateRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenerateRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>");
#nullable restore
#line 7 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
#nullable restore
#line 19 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Count(); row += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <code>");
#nullable restore
#line 21 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code>");
#nullable restore
#line 21 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code><br />\n");
#nullable restore
#line 22 "C:\HAULIO\FarmFresh2\src\Web\Views\Manage\GenerateRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenerateRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
