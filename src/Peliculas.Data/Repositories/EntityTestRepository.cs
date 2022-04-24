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
            return _context.PeliculaActores
                .Include(pa => pa.Pelicula)
                .ThenInclude(p => p.SalasDeCine)
                //.ThenInclude(s => s.Cine)
                .Where(pa => pa.ActorId == performingActor.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.Pelicula)
                .AsNoTracking()
                .ToList();
        }
    }
}
