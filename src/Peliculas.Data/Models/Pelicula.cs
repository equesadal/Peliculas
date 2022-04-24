using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Data.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool EnCartelera { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string PosterUrl { get; set; }
        public virtual ICollection<PeliculaActor> PeliculaActores { get; set; }
        public virtual ICollection<PeliculaSalaDeCine> PeliculasSalasDeCine { get; set; }
    }
}
