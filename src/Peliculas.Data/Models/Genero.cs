using System.Collections.Generic;

namespace Peliculas.Data.Models
{
    public class Genero
    {
        // Based on the model diagram, the Pelicula entity could have multiple Genrers, that is why it is added
        // as a many to any relationship.
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<GeneroPelicula> GenerosPelicula { get; set; }
    }
}
