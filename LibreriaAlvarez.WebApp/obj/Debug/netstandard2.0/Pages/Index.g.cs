#pragma checksum "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603edf10877f0e2193ec168e45aa584a38d871f5"
// <auto-generated/>
#pragma warning disable 1591
namespace LibreriaAlvarez.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using LibreriaAlvarez.WebApp.Shared;
    using LibreriaAlvarez.WebApp;
    using OfficeOpenXml;
    using FileLib;
    using System.Drawing;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Librería Alvarez</h1>\n\n");
            builder.AddMarkupContent(1, "<p>Las aplicaciones se pueden acceder desde el menú o desde acá: </p>\n");
            builder.AddMarkupContent(2, @"<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <div class=""list-group"">
                <a href=""fetch-prices"" class=""list-group-item list-group-item-action"">Buscar en list precios</a>
            </div>
            <div class=""list-group"">
                <a href=""load-prices"" class=""list-group-item list-group-item-action"">Cargar Listas</a>
            </div>
        </div>
        <div class=""col"">
        </div>
        <div class=""col"">
        </div>
    </div>

</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
