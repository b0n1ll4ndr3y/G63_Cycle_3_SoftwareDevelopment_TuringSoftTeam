#pragma checksum "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acda52ea6669e82145e761988885b3d1d0259fb9"
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
    public partial class CardComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron jumbotron-fluid");
#nullable restore
#line 2 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
     if (Movies == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<label><small class=\"text-muted\">Buscando películas</small></label>\n        <img src=\"/img/loading.gif\" height width>");
#nullable restore
#line 6 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
    }else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row mb-3");
#nullable restore
#line 10 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
             foreach (var movie in Movies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body d-flex flex-column align-items-start");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 16 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                           movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "alt", "img-thumbnail card-img-top");
            __builder.AddAttribute(18, "height", "300px");
            __builder.AddAttribute(19, "width", "200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenElement(23, "h6");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, 
#nullable restore
#line 18 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                                            movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                                    ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "text-muted");
            __builder.AddContent(29, 
#nullable restore
#line 20 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                         movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\n                                        <br>\n                                        ");
            __builder.AddContent(31, 
#nullable restore
#line 22 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                         movie.Category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\n                                        <br>\n                                        ");
            __builder.OpenElement(33, "small");
            __builder.AddContent(34, 
#nullable restore
#line 24 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                                movie.Casting

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                                        <br>\n                                        ");
            __builder.OpenElement(36, "small");
            __builder.AddContent(37, 
#nullable restore
#line 26 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                                movie.Premier

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n        ");
            __builder.AddMarkupContent(39, "<p>More info</p>\n        ");
            __builder.AddMarkupContent(40, "<p class=\"lead\"><a class=\"btn btn-primary btn-lg\" href=\"Jumbo action link\" role=\"button\">Jumbo action name</a></p>");
            __builder.CloseElement();
#nullable restore
#line 40 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
      
    public List<Movie> Movies;
    private List<Movie> GetMovies()
    {
        return new List<Movie>()
        {
            new Movie(){Name="Archer", Sinopsis="Trama de la película...", Image="/img/movies/poster_archer.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Back to the future", Sinopsis="Trama de la película...", Image="/img/movies/poster_backToTheFuture.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Joker", Sinopsis="Trama de la película...", Image="/img/movies/poster_joker.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Wolverine I", Sinopsis="Trama de la película...", Image="/img/movies/poster_wolverine.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Wolverine II", Sinopsis="Trama de la película...", Image="/img/movies/poster_wolverine_2.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="World War Z", Sinopsis="Trama de la película...", Image="/img/movies/poster_worldWarZ.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Antman", Sinopsis="Trama de la película...", Image="/img/movies/poster_antman.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="After", Sinopsis="Trama de la película...", Image="/img/movies/poster_after.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Star Trek", Sinopsis="Trama de la película...", Image="/img/movies/poster_starTrek.jpeg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()},
            new Movie(){Name="Suicide Squad", Sinopsis="Trama de la película...", Image="/img/movies/poster_suicideSquad.jpg", Premier=new DateTime(2021, 10, 15), Category=new Category(), Casting=new Casting()}
        };
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Components/CardComponent.razor"
                                                                          
    protected override async Task OnInitializedAsync(){
        await Task.Delay(2000);
        Movies = GetMovies();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
