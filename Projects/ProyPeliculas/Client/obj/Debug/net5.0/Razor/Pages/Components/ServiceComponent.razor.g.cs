#pragma checksum "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f5ae73a1395d6382bb8aa79d4b2364931c49a2"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculas.Client.Pages.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class ServiceComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row mb-3");
#nullable restore
#line 5 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
             foreach (var movie in Movies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-4");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body d-flex flex-column align-items-start");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 11 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
                                           movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "alt", "img-thumbnail card-img-top");
            __builder.AddAttribute(19, "height", "300px");
            __builder.AddAttribute(20, "width", "200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.OpenElement(24, "h6");
            __builder.AddAttribute(25, "class", "card-title");
            __builder.AddContent(26, 
#nullable restore
#line 13 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
                                                            movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                                    ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-muted");
            __builder.AddContent(30, 
#nullable restore
#line 15 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
                                         movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\n                                        <br>\n                                        ");
            __builder.AddContent(32, 
#nullable restore
#line 17 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
                                         movie.Category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\n                                        <br>\n                                        ");
            __builder.OpenElement(34, "small");
            __builder.AddContent(35, 
#nullable restore
#line 19 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
                                                movie.Casting

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                                        <br>\n                                        ");
            __builder.OpenElement(37, "small");
            __builder.AddContent(38, 
#nullable restore
#line 21 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
                                                movie.Premier

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                                ");
            __builder.AddMarkupContent(40, "<div><button @onClick=\"MovieDelete\">Eliminar</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.AddMarkupContent(42, "<p>More info</p>\n        ");
            __builder.AddMarkupContent(43, "<p class=\"lead\"><a class=\"btn btn-primary btn-lg\" href=\"Jumbo action link\" role=\"button\">Jumbo action name</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/ServiceComponent.razor"
      
    [Parameter] public List<Movie> Movies { get; set; }

    void MovieDelete()
    {
        Console.WriteLine($"Eliminando de cartelera la película");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
