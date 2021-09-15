// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAdmin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\HAULIO\FarmFresh\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : BlazorAdmin.Helpers.BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Shared\MainLayout.razor"
 
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var authState = await AuthStateProvider.GetAuthenticationStateAsync();

                if (authState.User == null)
                {
                    await new Route(JSRuntime).RouteOutside("/Identity/Account/Login");
                }
                CallRequestRefresh();
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
    }
}
#pragma warning restore 1591
