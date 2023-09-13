using TrainingManagment.Domain.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using TrainingManagment.Repository.Interfaces;
using TrainingManagment.Domain.Models;
using TrainingManagment.Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using TrainingManagment.Domain.consts;

namespace TrainingManagment.Presentation.Controllers
{
    [Authorize(Roles = RoleName.Admin)]
    public class SessionController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public SessionController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var session = await _unitOfWork.Sessions.GetAllAsync();

                if (session == null)
                {
                    return NotFound();

                }
                return View(session);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving sessions.");
                return View();
            }

        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var session = await _unitOfWork.Sessions.GetByIdAsync(id);

            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
       
        public async Task<IActionResult> Create([FromBody] List<Session> newSessionData)
        {

            try
            {
                foreach (var item in newSessionData)
                {
                    if (item != null)
                    {
                        item.CreatedBy = "dc9a8b7d-2014-445b-b63f-6d0ff68da9d7";
                        item.CreatedOn = DateTime.Now;
                        item.IsActive = true;
                        item.IsDeleted = false;
                        item.Year = "2023";

                        //item.TrainerName.Id =(int) item.TrainerNameId;
                        //item.TrainingTopic.Id = (int)item.TrainingTopicId;
                        //item.TrainingType.Id = (int)item.TrainingTypeId;

                        await _unitOfWork.Sessions.AddAsync(item);
                    }


                }
                await _unitOfWork.Complete();


                return Json(new { message = "Session data inserted successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Session session)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(session);
        //    }
        //    try
        //    {
        //        var exist = await _unitOfWork.Sessions.FindAllAsync(b => (int)b.Year == (int)session.Year);
        //        if(exist.Count() >0)
        //        {
        //            ModelState.AddModelError("Year", "This Year Already exist please update the session");
        //            return View();
        //        }
        //        // Call the repository layer to add the entity.
        //        var result = await _unitOfWork.Sessions.AddAsync(session);

        //        // I will use _unitOfWork.Complete(), when add, update and delete from database
        //        int a = await _unitOfWork.Complete();

        //        // Handle success and redirection.
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception.
        //        _logger.LogError(ex, "An error occurred while adding a session.");

        //        // Handle the exception, display a generic error message, and possibly redirect to an error page.
        //        ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
        //        return View(session);
        //    }

        //}

        //public async Task<IActionResult> Search(SessionViewModel session)
        //{
        //    if (session.Year != 0 || session.TrainingType == 0 &&
        //        session.TrainerName == 0 && session.TraineeName == null &&
        //        session.Status == 0 && session.Result == 0 &&
        //        session.StartDate.Equals(null) && session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => (int)b.Year == (int)session.Year);
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType != 0 ||
        //       session.TrainerName == 0 && session.TraineeName == null &&
        //       session.Status == 0 && session.Result == 0 &&
        //       session.StartDate.Equals(null) && session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => (int)b.TrainingType == (int)session.TrainingType);
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType == 0 &&
        //      session.TrainerName != 0 || session.TraineeName == null &&
        //      session.Status == 0 && session.Result == 0 &&
        //      session.StartDate.Equals(null) && session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => (int)b.TrainerName == (int)session.TrainerName);
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType == 0 &&
        //      session.TrainerName == 0 && session.TraineeName != null ||
        //      session.Status == 0 && session.Result == 0 &&
        //      session.StartDate.Equals(null) && session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => b.TraineeName.Contains(session.TraineeName));
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType == 0 &&
        //      session.TrainerName == 0 && session.TraineeName == null &&
        //      session.Status != 0 || session.Result == 0 &&
        //      session.StartDate.Equals(null) && session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => (int)b.Status == (int)session.Status);
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType == 0 &&
        //      session.TrainerName == 0 && session.TraineeName == null &&
        //      session.Status == 0 && session.Result != 0 ||
        //      session.StartDate.Equals(null) && session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => (int)b.Result == (int)session.Result);
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType == 0 &&
        //      session.TrainerName == 0 && session.TraineeName == null &&
        //      session.Status == 0 && session.Result == 0 &&
        //      session.StartDate.Equals(null) || session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => b.StartDate.Date == session.StartDate);
        //        return View(sessions);
        //    }

        //    if (session.Year == 0 && session.TrainingType == 0 &&
        //      session.TrainerName == 0 && session.TraineeName == null &&
        //      session.Status == 0 && session.Result == 0 &&
        //     !session.StartDate.Equals(null) || !session.ExpectedEndDate.Equals(null))
        //    {
        //        var sessions = await _unitOfWork.Sessions.FindAllAsync(b => b.ExpectedEndDate.Date == session.ExpectedEndDate);
        //        return View(sessions);
        //    }

        //    return View();
        //}

        //[HttpGet]
        //public IActionResult UpdateCurrent(int? year)
        //{
        //    try
        //    {
        //        if (year == null || year == 0)
        //        {
        //            return NotFound();
        //        }

        //        var sessions = _unitOfWork.Sessions.FindByYear(year);
        //        var a = sessions.Select(x => x.Year);

        //        return View();

        //    }
        //    catch (Exception ex)
        //    {

        //        // Log the exception.
        //        _logger.LogError(ex, "An error occurred while Updating a session.");

        //        // Handle the exception, display a generic error message, and possibly redirect to an error page.
        //        ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
        //        return View();
        //    }
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdateCurrent(Session model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);

        //    }
        //    model.Year = LookupEnum.Year.Year2023;
        //    _unitOfWork.Sessions.Update(model);
        //    _unitOfWork.Complete();
        //    return RedirectToAction("Index");

        //}

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update([FromBody] List<Session> newSessionData)
        {
            try
            {
                foreach (var item in newSessionData)
                {
                    if (item != null)
                    {
                        item.CreatedBy = "dc9a8b7d-2014-445b-b63f-6d0ff68da9d7";
                        item.CreatedOn = DateTime.Now;
                        item.IsActive = true;
                        item.IsDeleted = false;
                        item.Year = "2023";


                        //item.TrainingResult = _context.Lookup.Find(Session.TrainingResultId);
                        //item.TrainingTopic = _context.Lookup.Find(SessionViewModel.TrainingTopicId);
                        //item.TrainingType = _context.Lookup.Find(SessionViewModel.TrainingTypeId);
                        //item.TrainingStatus = _context.Lookup.Find(SessionViewModel.TrainingStatusId);
                        //item.TrainerName = _context.Lookup.Find(SessionViewModel.TrainerNameId);
                        //item.LookupYear = _context.Lookup.Find(SessionViewModel.LookupYearId);


                        _unitOfWork.Sessions.AddAsync(item);
                    }


                }
                _unitOfWork.Complete();


                return Json(new { message = "Session data inserted successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetSessions()
        {
            try
            {
                var sessions = await _unitOfWork.Sessions.GetAllAsync();

                if (sessions == null)
                {
                    return NotFound();

                }
              
                return Json(sessions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving sessions.");
                return View();
            }
        }


        //[HttpPost]
        //public async Task<IActionResult> CreateSession([FromBody] List<Session> sessions)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Json(new { Message = "Error" });
        //    }

        //    try
        //    {

                
        //        // Call the repository layer to add the entity
        //        // var result = await _unitOfWork.Sessions.AddAsync((Session)session);

        //        // I will use _unitOfWork.Complete(), when add, update and delete from the database
        //        // int a = await _unitOfWork.Complete();
        //        string message = "SUCCESS";
        //        return Json(new { Message = message });
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception.
        //        _logger.LogError(ex, "An error occurred while adding a session.");

        //        // Handle the exception, display a generic error message, and possibly redirect to an error page.
        //        ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
        //        return Json(new { Message = "Something went wrong" });
        //    }
        //}

    }
}
