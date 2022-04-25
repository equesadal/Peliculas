using NetTopologySuite.Geometries;
using Peliculas.Data.Models;
using System;
using System.Collections.Generic;

namespace Peliculas.Data.Repositories
{
    public interface IEntityTestRepository
    {
        IEnumerable<Pelicula> GetMoviesOnBillboardPaginated(Actor performingActor, int pageSize, int pageNumber);
        Genero GetFirstGenrerByLetter(char letter);
        IEnumerable<Genero> GetAllGenrers();
        IEnumerable<string> CurrentTheathersByMonthBillboardMovies();
        List<Tuple<Cine, double>> GetTeathersByLocation(Point currentLocation);
    }
}
