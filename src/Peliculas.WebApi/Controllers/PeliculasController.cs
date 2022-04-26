using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;
using Peliculas.Data.Geometry;
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
        public ActionResult<List<BillboardMovie>> Get(int actorId)
        {
            if (actorId <= 0)
            {
                return BadRequest($"The {nameof(actorId)} must be a number greater than zero.");
            }

            var movies = _repository.GetMoviesOnBillboardPaginated(new Actor { Id = actorId }, 5, 2);

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

            return Ok(result);
        }

        [HttpGet]
        [Route("GetFirstGenrer")]
        public ActionResult<Genero> GetGenrer()
        {
            char startingLetter = 'C';
            var genrer = _repository.GetFirstGenrerByLetter(startingLetter);

            if (genrer == null)
            {
                return NotFound();
            }
            return Ok(genrer);
        }

        [HttpGet]
        [Route("GetAllGenrers")]
        public Task<List<string>> GetAllGenrers()
        {
            var genrers = _repository.GetAllGenrers().Select(g => g.Nombre).ToList();

            return Task.FromResult(genrers);
        }

        [HttpGet]
        [Route("GetTeathers")]
        public Task<List<string>> GetTeathersByCurrentMonthBillboadMovies()
        {
            var teathers = _repository.CurrentTheathersByMonthBillboardMovies().ToList();

            return Task.FromResult(teathers);
        }

        [HttpGet]
        [Route("GetTeathersByLocation")]
        public Task<List<string>> GetTeathersByLocation()
        {
            Point currentLocation = GeometryFactoryHelper.GeometryFactory.CreatePoint(new Coordinate(9.83, -83.96));
            var teathers = _repository.GetTeathersByLocation(currentLocation).ToList();

            return Task.FromResult(teathers.Select(t => $"{t.Item1.Nombre}, distance: {t.Item2}").ToList());
        }
    }
}
