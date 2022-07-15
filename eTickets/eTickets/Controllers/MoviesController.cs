using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }
        // GET
        public async Task<ActionResult> Index()
        {
            var allMovies = await _moviesService.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }
        //Get/Movies/Id
        public async Task<ActionResult> Details(int id)
        {
            var movieDetails = await _moviesService.GetMovieByIdAsync(id);
            return View(movieDetails); 
        }
    }
}