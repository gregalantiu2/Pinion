#pragma checksum "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/PageHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28ffe654b9b57351244b4642e6cc0a6a8913bfb6"
// <auto-generated/>
#pragma warning disable 1591
namespace Pinion.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Pinion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Pinion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Pinion.Pages.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class PageHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "header");
            __builder.AddAttribute(2, "b-803vpdutx7");
            __builder.OpenComponent<MatBlazor.MatAppBarTitle>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 2 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/PageHeader.razor"
__builder2.AddContent(5, Title);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/PageHeader.razor"
       
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
