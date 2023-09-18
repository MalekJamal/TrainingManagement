using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TrainingManagment.Domain.Models;
using TrainingManagment.Presentation.Controllers;
using TrainingManagment.Repository.Interfaces;
using TrainingManagment.Repository.Repositories;

namespace TrainingManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ListApiController : ControllerBase
    {
        private readonly ILogger<ListApiController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ListApiController(IUnitOfWork unitOfWork, ILogger<ListApiController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet("Topics")]
        public IActionResult GetTopics()
        {
            List<Lookup> topics = _unitOfWork.Lookups.GetAllTopics();
            return Ok(topics);
        }

        [HttpGet("Types")]
        public IActionResult GetTypes()
        {
            List<Lookup> types = _unitOfWork.Lookups.GetAllTypes();
            return Ok(types);
        }

        [HttpGet("Trainers")]
        public IActionResult GetTrainers()
        {
            List<Lookup> trainers = _unitOfWork.Lookups.GetAllTrainer();
            return Ok(trainers);
        }
    }
}
