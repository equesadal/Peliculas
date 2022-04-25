using System;

namespace Peliculas.Data.Models
{
    public class CineOferta
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal PorcentajeDescuento { get; set; }
        public int CineId { get; set; }
        public Cine Cine { get; set; }
    }
}
