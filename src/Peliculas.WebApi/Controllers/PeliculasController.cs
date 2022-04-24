using Microsoft.AspNetCore.Mvc;
using Peliculas.Data.Models;
using Peliculas.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Peliculas.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly IEntityTestRepository _repository;

        public PeliculasController(IEntityTestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public Task<IEnumerable<Pelicula>> Get()
        {
            var movies = _repository.GetMoviesOnBillboardPaginated(new Actor { Id = 1 }, 5, 2);


            var results = new List<string>();
            results.Add("Hello world!");

            return Task.FromResult(movies);
        }
    }
}
