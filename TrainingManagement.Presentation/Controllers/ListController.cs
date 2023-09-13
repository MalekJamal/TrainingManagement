using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TrainingManagment.Domain.Models;
using TrainingManagment.Repository.Repositories;

namespace TrainingManagement.Presentation.Controllers
{
    public class ListController : Controller
    {
        private readonly LookupRepository _lookup;

        public ListController(LookupRepository lookup)
        {
            _lookup = lookup;
        }

        [HttpGet]
        public IActionResult Topics()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Types()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Trainers()
        {
            return View();
        }
    }
}
