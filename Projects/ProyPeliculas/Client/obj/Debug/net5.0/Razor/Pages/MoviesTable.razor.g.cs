#pragma checksum "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/MoviesTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0973a3df671bcf424372d8fc972f97ff83e06207"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculas.Client.Pages
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
#line 16 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/MoviesTable.razor"
using ProyPeliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/moviesdatatable")]
    public partial class MoviesTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProyPeliculas.Client.Pages.Components.DataTableComponent>(0);
            __builder.AddAttribute(1, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProyPeliculas.Shared.Entity.Movie>>(
#nullable restore
#line 5 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/MoviesTable.razor"
                            Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/MoviesTable.razor"
 
    private List<Movie> Movies;
    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
