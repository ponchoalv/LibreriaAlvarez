using FileLib;
using Microsoft.AspNetCore.Blazor;
using OfficeOpenXml;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibreriaAlvarez.WebApp.Services
{
    public class LibreriaPriceService
    {
        private readonly HttpClient _httpClient;
        private readonly string APIBaseURL;

        public LibreriaPriceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            APIBaseURL = "http://localhost:3000/api/";
        }

        public async Task<DateTime> GetLastDateAsync()
        {
            return await _httpClient.GetJsonAsync<DateTime>(APIBaseURL + "get-last-date");
        }

        public async Task<LibreriaPrice[]> GetPricesByDate(DateTime fecha)
        {
            return await _httpClient.GetJsonAsync<LibreriaPrice[]>(APIBaseURL + "prices-by-fecha?fecha=" + fecha.ToString("yyyy-MM-dd"));
        }

        public async Task<ListaFechas[]> GetLoadedDates()
        {
      
            return await _httpClient.GetJsonAsync<ListaFechas[]>(APIBaseURL + "get-all-dates").ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> PostCargarPlanilla(MultipartFormDataContent form) 
            => await _httpClient.PostAsync(APIBaseURL + "cargar-lista", form);

        public async Task DownLoadExcel(LibreriaPrice[] precios)
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
    }
}
