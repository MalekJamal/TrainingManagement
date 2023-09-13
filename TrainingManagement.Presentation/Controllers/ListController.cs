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
            var pageSize = 6;
            var skip = 1;


            //var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            //var sortColumnDirection = Request.Form["order[0][dir]"];
            List<Lookup> topics = new List<Lookup>();

            topics = _lookup.GetAllTopics();


            var data = topics.Skip(skip).Take(pageSize).ToList();

            var recordsTotal = topics.Count();

            var jsonData = new { recordsFiltered = recordsTotal, recordsTotal, data };

            return Json(jsonData);

        }

        public IActionResult Types()
        {
            List<Lookup> types = _lookup.GetAllTypes();
            return View(types);
        }

        public IActionResult Trainers()
        {
            List<Lookup> trainers = _lookup.GetAllTrainer();

            return View();
        }
    }
}
