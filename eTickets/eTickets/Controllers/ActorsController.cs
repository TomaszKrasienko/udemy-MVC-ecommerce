using System.Linq;
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
        public IActionResult Index()
        {
            var data = _actorsService.GetAll();
            return View(data);
        }
    }
}