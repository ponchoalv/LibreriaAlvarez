#pragma checksum "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca06be7770377fa2b7907626f100232811f81b9"
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
    using LibreriaAlvarez.WebApp.Services;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetch-prices")]
    public class ListaPrecios : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Lista de Precios</h1>\n\n");
#line 7 "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml"
 if (topPrecios == null)
{

#line default
#line hidden
            builder.AddContent(1, "    ");
            builder.AddMarkupContent(2, "<p><em>Cargando...</em></p>\n");
#line 10 "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            builder.OpenElement(4, "p");
            builder.AddContent(5, "Buscar entre ");
            builder.OpenElement(6, "b");
            builder.AddContent(7, total);
            builder.CloseElement();
            builder.AddContent(8, " articulos de librería y juguetes.");
            builder.CloseElement();
            builder.AddContent(9, "\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "container");
            builder.AddContent(12, "\n        ");
            builder.OpenElement(13, "div");
            builder.AddAttribute(14, "class", "row");
            builder.AddContent(15, "\n            ");
            builder.OpenElement(16, "div");
            builder.AddAttribute(17, "class", "col");
            builder.AddContent(18, "\n                ");
            builder.OpenElement(19, "div");
            builder.AddAttribute(20, "class", "input-group");
            builder.AddContent(21, "\n                    ");
            builder.AddMarkupContent(22, "<div class=\"input-group-prepend\">\n                        <span class=\"input-group-text\" id=\"buscar-addon\">Buscar por Nombre</span>\n                    </div>\n                    ");
            builder.OpenElement(23, "input");
            builder.AddAttribute(24, "type", "text");
            builder.AddAttribute(25, "placeholder", "ABACO");
            builder.AddAttribute(26, "value", searchCriteria);
            builder.AddAttribute(27, "oninput", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(OnChangeSearchCriteria));
            builder.AddAttribute(28, "class", "form-control");
            builder.AddAttribute(29, "aria-describedby", "buscar-addon");
            builder.AddAttribute(30, "aria-label", "Buscar Articulo");
            builder.CloseElement();
            builder.AddContent(31, "\n                ");
            builder.CloseElement();
            builder.AddContent(32, "\n            ");
            builder.CloseElement();
            builder.AddContent(33, "\n            ");
            builder.OpenElement(34, "div");
            builder.AddAttribute(35, "class", "col");
            builder.AddContent(36, "\n                ");
            builder.OpenElement(37, "div");
            builder.AddAttribute(38, "class", "input-group");
            builder.AddContent(39, "\n                    ");
            builder.AddMarkupContent(40, "<div class=\"input-group-prepend\">\n                        <span class=\"input-group-text\" id=\"buscar-codigo\">Buscar por Lista</span>\n                    </div>\n                    ");
            builder.OpenElement(41, "input");
            builder.AddAttribute(42, "type", "text");
            builder.AddAttribute(43, "placeholder", "Powerland");
            builder.AddAttribute(44, "value", searchCriteriaList);
            builder.AddAttribute(45, "oninput", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(OnChangeListSearch));
            builder.AddAttribute(46, "class", "form-control");
            builder.AddAttribute(47, "aria-describedby", "buscar-codigo");
            builder.AddAttribute(48, "aria-label", "Buscar por código");
            builder.CloseElement();
            builder.AddContent(49, "\n                ");
            builder.CloseElement();
            builder.AddContent(50, "\n            ");
            builder.CloseElement();
            builder.AddContent(51, "\n        ");
            builder.CloseElement();
            builder.AddContent(52, "\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(53, "\n    <br>\n    ");
            builder.OpenElement(54, "div");
            builder.AddAttribute(55, "class", "table-responsive");
            builder.AddContent(56, "\n        ");
            builder.OpenElement(57, "table");
            builder.AddAttribute(58, "class", "table table-striped");
            builder.AddContent(59, "\n            ");
            builder.AddMarkupContent(60, @"<thead class=""thead-dark"">
                <tr>
                    <th>Descripción</th>
                    <th>Lista</th>
                    <th>Precio</th>
                    <th>Fecha de la Lista</th>
                </tr>
            </thead>
            ");
            builder.OpenElement(61, "tbody");
            builder.AddContent(62, "\n");
#line 46 "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml"
                 foreach (var precio in topPrecios)
                {

#line default
#line hidden
            builder.AddContent(63, "                    ");
            builder.OpenElement(64, "tr");
            builder.AddContent(65, "\n                        ");
            builder.OpenElement(66, "td");
            builder.AddContent(67, precio.Desc);
            builder.CloseElement();
            builder.AddContent(68, "\n                        ");
            builder.OpenElement(69, "td");
            builder.AddContent(70, precio.Lista);
            builder.CloseElement();
            builder.AddContent(71, "\n                        ");
            builder.OpenElement(72, "td");
            builder.AddContent(73, precio.Price.ToString("C2"));
            builder.CloseElement();
            builder.AddContent(74, "\n                        ");
            builder.OpenElement(75, "td");
            builder.AddContent(76, precio.Fecha.ToString("yyyy-MM-dd"));
            builder.CloseElement();
            builder.AddContent(77, "\n                    ");
            builder.CloseElement();
            builder.AddContent(78, "\n");
#line 54 "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml"
                }

#line default
#line hidden
            builder.AddContent(79, "            ");
            builder.CloseElement();
            builder.AddContent(80, "\n        ");
            builder.CloseElement();
            builder.AddContent(81, "\n    ");
            builder.CloseElement();
            builder.AddContent(82, "\n");
            builder.AddMarkupContent(83, "    <br>\n    ");
            builder.OpenElement(84, "button");
            builder.AddAttribute(85, "class", "btn btn-primary");
            builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(DownLoadExcel));
            builder.AddContent(87, "Descargar Lista de Precios");
            builder.CloseElement();
            builder.AddMarkupContent(88, "\n    <br>\n    <br>\n");
#line 63 "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 66 "C:\Users\ponch\projects\LibreriaAlvarez\LibreriaAlvarez.WebApp\Pages\ListaPrecios.cshtml"
            
    LibreriaPrice[] precios;

    IEnumerable<LibreriaPrice> topPrecios;

    string searchCriteria = "";
    string searchCriteriaList = "";
    int total = 0;

    void OnChangeSearchCriteria(UIChangeEventArgs arg)
    {
        searchCriteria = arg.Value.ToString().ToUpper();
    }

    void OnChangeListSearch(UIChangeEventArgs arg)
    {
        searchCriteriaList = arg.Value.ToString().ToUpper();
    }

    protected override async Task OnInitAsync()
    {
        precios = await LibreriaPriceservice.GetPricesAsync().ConfigureAwait(false);

        topPrecios = await Task.Run(() => (from p in precios where p.Desc.Contains(searchCriteria) && p.Lista.Contains(searchCriteriaList) select p).Take(20)).ConfigureAwait(false);

        total = precios.Length;
    }

    protected async Task DownLoadExcel()
    {
        await Task.Run(async () =>
        {
            using (var package = new ExcelPackage())
            {

                var worksheet = package.Workbook.Worksheets.Add("Lista Precios");
                worksheet.DefaultColWidth = 25;

                //Aumentar tamaño de la columna descripción
                worksheet.Column(2).Width = 50;

                var header = worksheet.Cells["B1:F1"];
                header.Style.Font.Bold = true;
                header.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                header.Style.Font.Color.SetColor(Color.White);
                header.Style.Fill.BackgroundColor.SetColor(Color.DarkBlue);


                header.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                header.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                header.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                header.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;

                worksheet.Cells["B1"].Value = "Descripción";
                worksheet.Cells["C1"].Value = "Lista";
                worksheet.Cells["D1"].Value = "Codigo";
                worksheet.Cells["E1"].Value = "Precio";
                worksheet.Cells["F1"].Value = "Fecha";

                var tableBody = worksheet.Cells["B2:B2"].LoadFromCollection(
                    from p in precios
                    select new { p.Desc, p.Lista, p.Code, p.Price, p.Fecha }, false);

                tableBody.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                tableBody.Style.Fill.BackgroundColor.SetColor(Color.WhiteSmoke);

                tableBody.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                tableBody.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                tableBody.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                tableBody.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                tableBody.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);

                // formato del tipo de fecha
                var fechasCol = tableBody.Offset(0, 4, precios.Length, 1);
                fechasCol.Style.Numberformat.Format = "DDD d MMM yyyy";

                // formato del tipo de precio
                var precioCol = tableBody.Offset(0, 3, precios.Length, 1);
                precioCol.Style.Numberformat.Format = "$###,###,##0.00";

                await FileUtil.SaveAs("PreciosLibreria.xlsx", package.GetAsByteArray()).ConfigureAwait(false);
            }
        }).ConfigureAwait(false);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private LibreriaPriceService LibreriaPriceservice { get; set; }
    }
}
#pragma warning restore 1591
