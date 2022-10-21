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

        public async Task< IActionResult> Index()
        {

            var allActors =await _service.GetAll();
         
            return View(allActors);
        }


        //Get/Actors/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
