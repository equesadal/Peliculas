namespace Peliculas.Data.Models
{
    public class GeneroPelicula
    {
        // Navigation properties for many to many were not being properly resolved by EF, 
        // so for now I added an entity to configure the relationship between Genero and Pelicula.
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public int GeneroIdentificador { get; set; }
        public Genero Genero { get; set; }
    }
}
