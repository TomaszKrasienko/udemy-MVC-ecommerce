using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemasService;
        public CinemasController(ICinemasService cinemasService)
        {
            _cinemasService = cinemasService;
        }
        // GET
        public async Task<ActionResult> Index()
        {
            var allCinemas = await _cinemasService.GetAllAsync();
            return View(allCinemas);
        }
        //Get: Cinemas/Crete
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")]Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _cinemasService.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
        //Get: Cinema/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _cinemasService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
    }
}