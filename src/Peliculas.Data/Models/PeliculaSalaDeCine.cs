namespace Peliculas.Data.Models
{
    public class PeliculaSalaDeCine
    {
        // Navigation properties for many to many were not being properly resolved by EF, 
        // so for now I added an entity to configure the relationship between Pelicula and SalaDeCine.
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public int SalaDeCineId { get; set; }
        public SalaDeCine SalaDeCine { get; set; }
    }
}
