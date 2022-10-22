using com.sun.xml.@internal.bind.v2.model.core;
using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        //Get All Actors
        public async Task< IActionResult> Index()
        {

            var allActors =await _service.GetAllAsync();
         
            return View(allActors);
        }


        //Get/Actor/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        //Post/Actor/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(ModelState.IsValid)
            {
                return View(actor);
            }
           await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
            
        }

        //Get/Actor/Details
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await  _service.GetByIdAsync(id);
            if(actorDetails==null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }



        //Get/Actor/Update
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);

        }

        //Post/Actor/Update
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }


        //Get/Actor/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);

        }

        //Post/Actor/Delete
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }


}

