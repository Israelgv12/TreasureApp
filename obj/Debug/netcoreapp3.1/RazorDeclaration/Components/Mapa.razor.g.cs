#pragma checksum "C:\Programacion3\Tesoro\Components\Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d833dfbe79ebab4f2d4f94318a3184dbb9c7c3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tesoro.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Programacion3\Tesoro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programacion3\Tesoro\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programacion3\Tesoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programacion3\Tesoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Programacion3\Tesoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Programacion3\Tesoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programacion3\Tesoro\_Imports.razor"
using Tesoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Programacion3\Tesoro\_Imports.razor"
using Tesoro.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Programacion3\Tesoro\Components\Mapa.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programacion3\Tesoro\Components\Mapa.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programacion3\Tesoro\Components\Mapa.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programacion3\Tesoro\Components\Mapa.razor"
using Tesoro.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Programacion3\Tesoro\Components\Mapa.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programacion3\Tesoro\Components\Mapa.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Programacion3\Tesoro\Components\Mapa.razor"
       
    [Parameter]
    public string TID {get; set;}

    List<Coordinate> coordinates;
    List<Treasure> treasures;
   
    protected override async Task OnAfterRenderAsync(bool firstRender){
        if (firstRender){
            if(TID != null)
            await Load();
        }
    }

    private async Task Load(){
        if(TID != null && TID != ""){
            coordinates = await TS.GetAllCoordinate(Guid.Parse(TID));
            treasures = await TS.GetAllTreasure(Guid.Parse(TID));
            string json = JsonSerializer.Serialize(coordinates.ToArray());
            string TJson = JsonSerializer.Serialize(treasures.ToArray());
            await runtime.InvokeVoidAsync("initMap", json, 8, TJson);
        }else{
            await runtime.InvokeVoidAsync("initMap");
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITesoroService TS { get; set; }
    }
}
#pragma warning restore 1591
