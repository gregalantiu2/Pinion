#pragma checksum "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a47483f6af7374ae1e53d5c74827693073db2e"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "side-nav-grid");
            __builder.AddAttribute(2, "b-443o10cu7x");
            __builder.OpenComponent<MatBlazor.MatNavMenu>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 4 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/NavMenu.razor"
         foreach (var item in NavItems)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatNavItem>(5);
                __builder2.AddAttribute(6, "href", "");
                __builder2.AddAttribute(7, "Match", "NavLinkMatch.All");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 7 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/NavMenu.razor"
__builder3.AddContent(9, item);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 9 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/NavMenu.razor"
        }

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
#line 15 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/NavMenu.razor"
       
    private string[] NavItems = new string[] { "Home","Explore","Notifications" };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
