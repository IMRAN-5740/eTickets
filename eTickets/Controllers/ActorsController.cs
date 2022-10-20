using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ActorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var allActors = _context.Actors.ToList();
         
            return View(allActors);
        }
    }
}
