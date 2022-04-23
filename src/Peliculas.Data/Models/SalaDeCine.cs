using System.Collections.Generic;

namespace Peliculas.Data.Models
{
    public class SalaDeCine
    {
        public int Id { get; set; }
        public string TipoSalaCine { get; set; }
        public decimal Precio { get; set; }
        public int CineId { get; set; }
        public Cine Cine { get; set; }
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
