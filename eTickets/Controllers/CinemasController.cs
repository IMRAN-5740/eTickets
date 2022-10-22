using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        //Get All Actors
        public async Task<IActionResult> Index()
        {

            var allActors = await _service.GetAllAsync();

            return View(allActors);
        }


        //Get/Actor/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        //Post/Actor/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));

        }

        //Get/Ciname/Details
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);
        }



        //Get/Cinema/Update
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);

        }

        //Post/Cinema/Update
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo,Name,Description")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                return View(cinema);
            }

            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }


        //Get/Cinema/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);

        }

        //Post/Cinema/Delete
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
