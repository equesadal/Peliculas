using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.Data.Contexts;
using Peliculas.Data.Geometry;
using Peliculas.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peliculas.Data.Repositories
{
    public class EntityTestRepository : IEntityTestRepository
    {
        private readonly PeliculasContext _context;

        public EntityTestRepository(PeliculasContext context)
        {
            _context = context;
        }

        public IEnumerable<Pelicula> GetMoviesOnBillboardPaginated(Actor performingActor, int pageSize, int pageNumber)
        {
            return _context.PeliculaActores                 // Some notes about this query:
                .Include(pa => pa.Pelicula)                 // Using eager loading
                .ThenInclude(p => p.PeliculasSalasDeCine)
                .ThenInclude(p => p.SalaDeCine)
                .ThenInclude(p => p.Cine)
                .Where(pa => pa.ActorId == performingActor.Id && pa.Pelicula.EnCartelera == true)
                .Skip((pageNumber - 1) * pageSize)          // then skipping first page
                .Take(pageSize)                             // and taking the whole 2nd page (not only 2 rows, will do it in the upper call)
                .Select(p => p.Pelicula)
                .AsNoTracking()                             // finally dont track the query
                .ToList();                                  // we can materialize the page of data here as few rows (no more than 5) are returned
        }

        public Genero GetFirstGenrerByLetter(char letter)
        {
            if (char.IsWhiteSpace(letter))
            {
                throw new ArgumentException("The letter must be a valid initial char.");
            }

            var query = from g in _context.Generos          // Using query syntax to define this query
                    where g.Nombre.StartsWith(letter.ToString())
                    orderby g.Nombre
                    select g;

            return query.FirstOrDefault<Genero>();
        }

        public IEnumerable<Genero> GetAllGenrers()
        {
            return _context.Generos
                .OrderByDescending(g => g.Nombre);
        }

        public IEnumerable<string> CurrentTheathersByMonthBillboardMovies()
        {
            var movies = _context.Peliculas
                .Include(p => p.PeliculasSalasDeCine)
                .ThenInclude(p => p.SalaDeCine)
                .ThenInclude(p => p.Cine)
                .Where(p => p.EnCartelera && p.FechaEstreno.Year == DateTime.Now.Year && p.FechaEstreno.Month == DateTime.Now.Month);

            var theaters = movies.SelectMany(p => p.PeliculasSalasDeCine).ToList();

            return theaters.Select(t => t.SalaDeCine.Cine.Nombre).Distinct();
        }

        public List<Tuple<Cine, double>> GetTeathersByLocation(Point currentLocation)
        {
            var teathers = _context.Cines.ToList();
            var teathersWithDistance = teathers
                .Select(t => Tuple.Create(t, DistanceCalculator.CalculateDistance(currentLocation, t.Ubicacion))).ToList();
            
            return teathersWithDistance.OrderBy(t => t.Item2).ToList();
        }
    }
}
