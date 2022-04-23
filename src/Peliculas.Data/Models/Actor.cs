using System;
using System.Collections.Generic;

namespace Peliculas.Data.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual ICollection<PeliculaActor> PeliculaActores { get; set; }
    }
}
