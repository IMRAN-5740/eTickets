using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        //Get All Producers
        public async Task<IActionResult> Index()
        {

            var allProducers = await _service.GetAllAsync();

            return View(allProducers);
        }
        //Get/Producer/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        //Post/Producer/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));

        }

        



        //Get/Producer/Update
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);

        }


        //Post/Producer/Update
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                return View(producer);
            }

            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }

        //Get/Producer/Details
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }

        //Get/Produce/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);

        }

        //Post/Producers/Delete
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
