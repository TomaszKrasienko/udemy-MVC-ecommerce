using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;
        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAll();
            return View(data);
        }
    }
}