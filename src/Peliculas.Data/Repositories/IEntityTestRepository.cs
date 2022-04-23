using Peliculas.Data.Models;
using System.Collections.Generic;

namespace Peliculas.Data.Repositories
{
    public interface IEntityTestRepository
    {
        IEnumerable<Pelicula> GetMoviesOnBillboardPaginated(Actor performingActor, int pageSize, int pageNumber);
    }
}
