using System;
using System.Collections.Generic;

namespace Peliculas.WebApi.DTOs
{
    public class BillboardMovie
    {
        public string Titulo { get; set; }
        public DateTime Estreno { get; set; }
        public List<string> Generos { get; set; }
        public List<string> Cines { get; set; }
    }
}
