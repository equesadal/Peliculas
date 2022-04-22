using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Peliculas.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeliculasController : ControllerBase
    {
        [HttpGet]
        []
        public Task<List<string>> Get()
        {
            var results = new List<string>();
            results.Add("Hello world!");

            return Task.FromResult(results);
        }
    }
}
