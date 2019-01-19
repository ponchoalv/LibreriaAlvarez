using System;

namespace LibreriaAlvarez.WebApp.Services
{
    public class LibreriaPrice
    {
        public decimal Price { get; set; }
        public string Lista { get; set; }
        public string Code { get; set; }
        public string Desc { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class ListaFechas
    {
        public DateTime Fecha { get; set; }
    }

    public class LoadedList
    {
        public int Registros { get; set; }
        public string Lista { get; set; }
        public DateTime Fecha { get; set; }
    }
}
