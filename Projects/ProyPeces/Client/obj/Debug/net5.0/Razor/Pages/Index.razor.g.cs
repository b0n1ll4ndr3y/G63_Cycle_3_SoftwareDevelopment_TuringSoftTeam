#pragma checksum "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247be6efc83d67eb18612104e57718fe4e1f4f6f"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeces.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron jumbotron-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "<h1 class=\"display-3\">Catálogo de peces</h1>\r\n        ");
            __builder.AddMarkupContent(5, "<p class=\"lead\">Banco de peces marinos</p>\r\n        <hr class=\"my-2\">\r\n        ");
            __builder.AddMarkupContent(6, "<p>Mas Información</p>\r\n\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "<img src=\"/img/PezDiscutirRosa.jpg\" alt class=\"card-img-top\" height>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "card-title");
            __builder.OpenElement(14, "em");
            __builder.AddContent(15, 
#nullable restore
#line 13 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                            cardTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "small");
            __builder.AddAttribute(18, "class", "text-muted");
            __builder.AddContent(19, 
#nullable restore
#line 14 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                           cardText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.AddMarkupContent(21, "<footer class=\"blockcuote-footer\"><small>Autor 1</small></footer>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card");
            __builder.AddMarkupContent(25, "<img src=\"/img/PezGloboMarron.jpg\" alt class=\"card-img-top\" height>\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body");
            __builder.OpenElement(28, "h5");
            __builder.AddAttribute(29, "class", "card-title");
            __builder.OpenElement(30, "em");
            __builder.AddContent(31, 
#nullable restore
#line 24 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                            cardTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "small");
            __builder.AddAttribute(34, "class", "text-muted");
            __builder.AddContent(35, 
#nullable restore
#line 25 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                           cardText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.AddMarkupContent(37, "<footer class=\"blockcuote-footer\"><small>Autor 2</small></footer>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card");
            __builder.AddMarkupContent(41, "<img src=\"/img/PezLeon.jpg\" alt class=\"card-img-top\" height>\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card-body");
            __builder.OpenElement(44, "h5");
            __builder.AddAttribute(45, "class", "card-title");
            __builder.OpenElement(46, "em");
            __builder.AddContent(47, 
#nullable restore
#line 35 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                            cardTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "small");
            __builder.AddAttribute(50, "class", "text-muted");
            __builder.AddContent(51, 
#nullable restore
#line 36 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                           cardText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.AddMarkupContent(53, "<footer class=\"blockcuote-footer\"><small>Autor 3</small></footer>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n        ");
            __builder.AddMarkupContent(55, "<p class=\"lead\"><a class=\"btn btn-primary btn-lg\" href=\"Jumbo action link\" role=\"button\">Jumbo action name</a></p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n    ");
            __builder.AddMarkupContent(57, @"<div><nav aria-label=""Page navigation example""><ul class=""pagination justify-content-center""><li class=""page-item""><a class=""page-link"" href=""#"" aria-label=""Previous""><span aria-hidden=""true"">&laquo;</span>
                        <span class=""sr-only"">Previous</span></a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"" aria-label=""Next""><span aria-hidden=""true"">&raquo;</span>
                        <span class=""sr-only"">Next</span></a></li></ul></nav></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeces/Client/Pages/Index.razor"
                                  
    public string cardTitle = "Tipo Pez";
    public string cardText = "Descripción del pez";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
