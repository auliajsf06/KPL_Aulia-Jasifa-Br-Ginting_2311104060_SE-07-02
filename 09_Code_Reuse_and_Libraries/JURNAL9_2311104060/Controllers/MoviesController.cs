using Microsoft.AspNetCore.Mvc;
using JURNAL9_2311104060.Models;

namespace JURNAL9_2311104060.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over years and find redemption."
            },
            new Movie {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Movie {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman faces the Joker, a criminal mastermind who plunges Gotham into chaos."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            if (id < 0 || id >= movies.Count) return NotFound();
            return Ok(movies[id]);
        }

        [HttpPost]
        public ActionResult AddMovie([FromBody] Movie movie)
        {
            movies.Add(movie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count) return NotFound();
            movies.RemoveAt(id);
            return Ok();
        }
    }
}
