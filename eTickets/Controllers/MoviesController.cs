using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies=await _service.GetAllAsync();

            return View(allMovies);
        }


        //Get/Movies/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        //Post/Movies/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,ImageURL,Description,Price,StartDate,EndDate,MovieCategory,CinemaId,ProducerId")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            await _service.AddAsync(movie);
            return RedirectToAction(nameof(Index));

        }
    }
}
