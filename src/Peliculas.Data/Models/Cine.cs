using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Data.Models
{
    public class Cine
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Point Ubicacion { get; set; }
        public CineOferta CineOferta { get; set; }
    }
}
