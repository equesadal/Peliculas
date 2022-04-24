using Microsoft.EntityFrameworkCore;
using Peliculas.Data.Contexts;
using Peliculas.Data.Models;
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
    }
}
