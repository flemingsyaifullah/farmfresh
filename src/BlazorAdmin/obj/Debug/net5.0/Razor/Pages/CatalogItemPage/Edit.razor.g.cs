#pragma checksum "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5a711105ffd287c4e4e6e6e3bb63b7776198c3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdmin.Pages.CatalogItemPage
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
    public partial class Edit : BlazorAdmin.Helpers.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 9 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                   _modalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 9 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                            _modalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                             _item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                    SaveClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "modal-header");
                __builder2.OpenElement(18, "h5");
                __builder2.AddAttribute(19, "class", "modal-title");
                __builder2.AddAttribute(20, "id", "exampleModalLabel");
                __builder2.AddContent(21, "Edit ");
                __builder2.AddContent(22, 
#nullable restore
#line 15 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                         _item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n                    ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "type", "button");
                __builder2.AddAttribute(26, "class", "close");
                __builder2.AddAttribute(27, "data-dismiss", "modal");
                __builder2.AddAttribute(28, "aria-label", "Close");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                                                          Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(30, "<span aria-hidden=\"true\">&times;</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "modal-body");
#nullable restore
#line 22 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                     if (_item == null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorAdmin.Shared.Spinner>(34);
                __builder2.CloseComponent();
#nullable restore
#line 25 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "container");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
#nullable restore
#line 30 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                 if (HasPicture)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(39, "img");
                __builder2.AddAttribute(40, "class", "col-md-6 esh-picture");
                __builder2.AddAttribute(41, "src", 
#nullable restore
#line 32 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                            LoadPicture

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 33 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-" + (
#nullable restore
#line 34 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                     HasPicture?"6":"12"

#line default
#line hidden
#nullable disable
                ) + " ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label class=\"control-label col-md-6\">Name</label>\n                                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-12");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                                         _item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _item.Name = __value, _item.Name))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _item.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n                                            ");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateValidationMessage_0(__builder2, 55, 56, 
#nullable restore
#line 40 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    (() => _item.Name)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n\n                                    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label class=\"control-label col-md-6\">Description</label>\n                                        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-md-12");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                                         _item.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _item.Description = __value, _item.Description))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _item.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n                                            ");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateValidationMessage_1(__builder2, 69, 70, 
#nullable restore
#line 48 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    (() => _item.Description)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n                                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-12");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "<label class=\"control-label col-md-6\">Brand</label>\n                                        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-md-12");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateCustomInputSelect_2(__builder2, 79, 80, "form-control", 81, 
#nullable restore
#line 57 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                            _item.CatalogBrandId

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _item.CatalogBrandId = __value, _item.CatalogBrandId)), 83, () => _item.CatalogBrandId, 84, (__builder3) => {
#nullable restore
#line 58 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                 foreach (var brand in Brands)
                                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 60 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    brand.Id.ToString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(87, 
#nullable restore
#line 60 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                                          brand.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 61 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(88, "\n                                            ");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateValidationMessage_3(__builder2, 89, 90, 
#nullable restore
#line 63 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    (() => _item.CatalogBrandId)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n\n                                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddMarkupContent(94, "<label class=\"control-label col-md-6\">Type</label>\n                                        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-md-12");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateCustomInputSelect_4(__builder2, 97, 98, "form-control", 99, 
#nullable restore
#line 70 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                            _item.CatalogTypeId

#line default
#line hidden
#nullable disable
                , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _item.CatalogTypeId = __value, _item.CatalogTypeId)), 101, () => _item.CatalogTypeId, 102, (__builder3) => {
#nullable restore
#line 71 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                 foreach (var type in Types)
                                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(103, "option");
                    __builder3.AddAttribute(104, "value", 
#nullable restore
#line 73 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    type.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(105, 
#nullable restore
#line 73 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                              type.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 74 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(106, "\n                                            ");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateValidationMessage_5(__builder2, 107, 108, 
#nullable restore
#line 76 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    (() => _item.CatalogTypeId)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n\n                                    ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group");
                __builder2.AddMarkupContent(112, "<label class=\"control-label col-md-6\">Price</label>\n                                        ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "col-md-12");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateInputNumber_6(__builder2, 115, 116, "form-control", 117, 
#nullable restore
#line 83 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                      _item.Price

#line default
#line hidden
#nullable disable
                , 118, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _item.Price = __value, _item.Price)), 119, () => _item.Price);
                __builder2.AddMarkupContent(120, "\n                                            ");
                __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit.TypeInference.CreateValidationMessage_7(__builder2, 121, 122, 
#nullable restore
#line 84 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                    (() => _item.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 90 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\n                ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "modal-footer");
                __builder2.OpenElement(126, "button");
                __builder2.AddAttribute(127, "type", "button");
                __builder2.AddAttribute(128, "class", "btn btn-secondary");
                __builder2.AddAttribute(129, "data-dismiss", "modal");
                __builder2.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
                                                                                                   Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(131, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\n                    ");
                __builder2.AddMarkupContent(133, "<button type=\"submit\" class=\"btn btn-primary\">\n                        Save\n                    </button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 105 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
 if (_showEditModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(134, "<div class=\"modal-backdrop fade show\"></div>");
#nullable restore
#line 108 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\HAULIO\FarmFresh\src\BlazorAdmin\Pages\CatalogItemPage\Edit.razor"
       
    [Parameter]
    public IEnumerable<CatalogBrand> Brands { get; set; }
    [Parameter]
    public IEnumerable<CatalogType> Types { get; set; }

    [Parameter]
    public EventCallback<string> OnSaveClick { get; set; }

    private string LoadPicture => string.IsNullOrEmpty(_item.PictureBase64) ? string.IsNullOrEmpty(_item.PictureUri) ? string.Empty : $"{_item.PictureUri}" : $"data:image/png;base64, {_item.PictureBase64}";
    private bool HasPicture => !(string.IsNullOrEmpty(_item.PictureBase64) && string.IsNullOrEmpty(_item.PictureUri));
    private string _badFileMessage = string.Empty;
    private string _modalDisplay = "none;";
    private string _modalClass = "";
    private bool _showEditModal = false;
    private CatalogItem _item = new CatalogItem();

    private async Task SaveClick()
    {
        await CatalogItemService.Edit(_item);
        await OnSaveClick.InvokeAsync(null);
        await Close();
    }

    public async Task Open(int id)
    {
        Logger.LogInformation("Now loading... /Catalog/Edit/{Id}", id);

        await new Css(JSRuntime).HideBodyOverflow();

        _item = await CatalogItemService.GetById(id);

        _modalDisplay = "block;";
        _modalClass = "Show";
        _showEditModal = true;

        StateHasChanged();
    }

    private async Task Close()
    {
        await new Css(JSRuntime).ShowBodyOverflow();

        _modalDisplay = "none";
        _modalClass = "";
        _showEditModal = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICatalogItemService CatalogItemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Edit> Logger { get; set; }
    }
}
namespace __Blazor.BlazorAdmin.Pages.CatalogItemPage.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorAdmin.Shared.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorAdmin.Shared.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591