using Microsoft.AspNetCore.Mvc;
using Peliculas.Data.Models;
using Peliculas.Data.Repositories;
using Peliculas.WebApi.DTOs;
using System.Collections.Generic;
using System.Linq;
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
        public Task<List<BillboardMovie>> Get()
        {
            var movies = _repository.GetMoviesOnBillboardPaginated(new Actor { Id = 1 }, 5, 2);

            var result = new List<BillboardMovie>().Take(2).ToList();
            foreach (var movie in movies)
            {
                var movieToAdd = new BillboardMovie {
                    Titulo = movie.Titulo,
                    Estreno = movie.FechaEstreno,
                    Generos = new List<string> { "Pending" },
                    Cines = movie.PeliculasSalasDeCine.Select(p => p.SalaDeCine.Cine.Nombre).ToList()
                };

                result.Add(movieToAdd);
            }

            return Task.FromResult(result);
        }
    }
}
