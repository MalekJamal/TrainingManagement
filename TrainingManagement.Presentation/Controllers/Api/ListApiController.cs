using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrainingManagment.Domain.Models;
using TrainingManagment.Repository.Repositories;

namespace TrainingManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListApiController : ControllerBase
    {
        private readonly LookupRepository _lookup;

        public ListApiController(LookupRepository lookup)
        {
            _lookup = lookup;
        }

        [HttpGet("Topics")]
        public IActionResult GetTopics()
        {
            List<Lookup> topics = _lookup.GetAllTopics();
            return Ok(topics);
        }

        [HttpGet("Types")]
        public IActionResult GetTypes()
        {
            List<Lookup> types = _lookup.GetAllTypes();
            return Ok(types);
        }

        [HttpGet("Trainers")]
        public IActionResult GetTrainers()
        {
            List<Lookup> trainers = _lookup.GetAllTrainer();
            return Ok(trainers);
        }
    }
}
