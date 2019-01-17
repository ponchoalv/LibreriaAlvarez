using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibreriaAlvarez.WebApp.Services
{
    public class FormCarga
    {
        public ByteArrayContent ListaFile { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoLista { get; set; }
        public string NombreLista { get; set; }
        public string NombreHoja { get; set; }
    }

    public class Respuesta
    {
        public bool Success { get; set; }
    }
}
