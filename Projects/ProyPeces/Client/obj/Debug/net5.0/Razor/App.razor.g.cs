#pragma checksum "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "021d7d5decb5589f6f6be24d5824910fbe91f48b"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeces.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using ProyPeces.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/_Imports.razor"
using ProyPeces.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(8);
                __builder2.AddAttribute(9, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "<p>Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
