using System.Threading.Tasks;
using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        // GET
        public async Task<ActionResult> Index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}