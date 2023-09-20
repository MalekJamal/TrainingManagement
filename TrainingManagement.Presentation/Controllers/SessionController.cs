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
using TrainingManagment.Repository.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.Domain.ViewModels;

namespace TrainingManagment.Presentation.Controllers
{
    [Authorize(Roles = RoleName.Admin)]
    public class SessionController : Controller
    {
        private readonly ILogger<SessionController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public SessionController(ILogger<SessionController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public SessionViewModel MapSessionToViewModel(Session session)
        {
            return new SessionViewModel
            {
                SessionId = session.SessionId,
                StartDate = session.StartDate,
                ExpectedEndDate = session.ExpectedEndDate,
                ActualEndDate = session.ActualEndDate,
                Year = session.Year,
                TraineeName = session.TraineeName,
                FinalPresentationDate = session.FinalPresentationDate,
                EvaluationScore = session.EvaluationScore,
                Comment = session.Comment,
                TrainingResultId = session.TrainingResultId,
                TrainingTopicId = session.TrainingTopicId,
                TrainingTypeId = session.TrainingTypeId,
                TrainingStatusId = session.TrainingStatusId,
                TrainerNameId = session.TrainerNameId,
                TrainerName = session.TrainerName,
                TrainingStatus = session.TrainingStatus,
                TrainingResult = session.TrainingResult,
                TrainingTopic = session.TrainingTopic,
                TrainingType = session.TrainingType,
                ResultsList = _unitOfWork.Lookups.GetAllResults(),
                TopicsList = _unitOfWork.Lookups.GetAllTopics(),
                TypesList = _unitOfWork.Lookups.GetAllTypes(),
                TrainersList = _unitOfWork.Lookups.GetAllTrainer(),
                StatusList = _unitOfWork.Lookups.GetAllStatus(),
                YearsList = _unitOfWork.Lookups.GetAllYear(),
            };
        }

        public async Task<SessionViewModel> MapSessionToViewModelWithAll(Session session)
        {
            return new SessionViewModel
            {
                SessionId = session.SessionId,
                StartDate = session.StartDate,
                ExpectedEndDate = session.ExpectedEndDate,
                ActualEndDate = session.ActualEndDate,
                Year = session.Year,
                TraineeName = session.TraineeName,
                FinalPresentationDate = session.FinalPresentationDate,
                EvaluationScore = session.EvaluationScore,
                Comment = session.Comment,
                TrainingResultId = session.TrainingResultId,
                TrainingTopicId = session.TrainingTopicId,
                TrainingTypeId = session.TrainingTypeId,
                TrainingStatusId = session.TrainingStatusId,
                TrainerNameId = session.TrainerNameId,
                ResultsList = _unitOfWork.Lookups.GetAllResults(),
                TopicsList = _unitOfWork.Lookups.GetAllTopics(),
                TypesList = _unitOfWork.Lookups.GetAllTypes(),
                TrainersList = _unitOfWork.Lookups.GetAllTrainer(),
                StatusList = _unitOfWork.Lookups.GetAllStatus(),
                YearsList = _unitOfWork.Lookups.GetAllYear(),
                TrainerName = session.TrainerName,
                TrainingStatus = session.TrainingStatus,
                TrainingResult = session.TrainingResult,
                TrainingTopic = session.TrainingTopic,
                TrainingType = session.TrainingType,
                SessionsList = await _unitOfWork.Sessions.FindAllAsync(s => s.IsActive == true && s.IsDeleted == false, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus", "TrainingResult" })


            };
        }

        public Session MapViewModelToSession(SessionViewModel viewModel)
        {
            return new Session
            {
                SessionId = viewModel.SessionId,
                StartDate = viewModel.StartDate,
                ExpectedEndDate = viewModel.ExpectedEndDate,
                ActualEndDate = viewModel.ActualEndDate,
                Year = viewModel.Year,
                TraineeName = viewModel.TraineeName,
                FinalPresentationDate = viewModel.FinalPresentationDate,
                EvaluationScore = viewModel.EvaluationScore,
                Comment = viewModel.Comment,
                TrainingResultId = viewModel.TrainingResultId,
                TrainingTopicId = viewModel.TrainingTopicId,
                TrainingTypeId = viewModel.TrainingTypeId,
                TrainingStatusId = viewModel.TrainingStatusId,
                TrainerNameId = viewModel.TrainerNameId,

            };
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                IEnumerable<Session> session = await _unitOfWork.Sessions.FindAllAsync(s => s.IsActive == true && s.IsDeleted == false, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus" });

                if (session == null)
                {
                    return NotFound();

                }

                //SessionViewModel session2   = new SessionViewModel();
                //session2 = MapSessionToViewModel(session.FirstOrDefault());
                /////
                SearchSessionViewModel sessionSearchViewModel = new SearchSessionViewModel();

                List<SessionViewModel> sessionsViewModel = new List<SessionViewModel>();
                foreach (Session session1 in session)
                {
                    sessionsViewModel.Add(MapSessionToViewModel(session1));
                }

                ViewBag.SessionsViewModel = sessionsViewModel;
                ViewBag.Types = _unitOfWork.Lookups.GetAllTypes().ToList();
                ViewBag.Topics = _unitOfWork.Lookups.GetAllTopics().ToList();
                ViewBag.Trainers = _unitOfWork.Lookups.GetAllTrainer().ToList();
                ViewBag.Status = _unitOfWork.Lookups.GetAllStatus().ToList();
                ViewBag.Years = _unitOfWork.Lookups.GetAllYear().ToList();
                ViewBag.Results = _unitOfWork.Lookups.GetAllResults().ToList();


                return View(sessionSearchViewModel);

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
            var session = await _unitOfWork.Sessions.FindAsync(s => s.SessionId == id, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus" });

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
                        item.CreatedBy = User.Identity.Name;
                        item.CreatedOn = DateTime.Now;
                        item.IsActive = true;
                        item.IsDeleted = false;
                        item.Year = "2024";

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
        [HttpGet]
        public async Task<IActionResult> Search(SearchSessionViewModel session)
        {
            // Start with an initial query to get all active and non-deleted sessions
            var query = await _unitOfWork.Sessions.FindAllAsync(s => s.IsActive == true && s.IsDeleted == false, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus" });

            // Build the query dynamically based on search criteria
            if (session.Year != null)
            {
                query = query.Where(s => s.Year == session.Year);
            }

            if (session.Type != null)
            {
                query = query.Where(s => s.TrainingType.NameEn == session.Type);
            }

            if (session.TrainerName != null)
            {
                query = query.Where(s => s.TrainerName.NameEn == session.TrainerName);
            }

            if (session.TraineeName != null)
            {
                query = query.Where(s => s.TraineeName.Contains(session.TraineeName));
            }
            //var space = session.StartDate?.Date.ToString().IndexOf(' ');
            //var sd = session.StartDate?.Date.ToString().Substring(0, space);
            //if (sd != null)
            //{
            //    query = query.Where(s => s.StartDate.Date.ToString().Substring(0, space) == sd);
            //}

            //space = session.EndDate.Date.ToString().IndexOf(' ');
            //var ed = session.StartDate.Date.ToString().Substring(0, space);
            //if (sd != null)
            //{
            //    query = query.Where(s => s.ExpectedEndDate.Date.ToString().Substring(0, space) == ed);
            //}

            //if (session.Status != null)
            //{
            //    query = query.Where(s => s.TrainingStatus.NameEn == session.Status);
            //}

            //if (session.Result != null)
            //{
            //    query = query.Where(s => s.TrainingResult.NameEn == session.Result);
            //}

            // Execute the final query and retrieve the results
            var filteredSessions = query.ToList();

            // Create and populate the view model with the filtered sessions
            var viewModel = new SearchSessionViewModel
            {
                Sessions = filteredSessions
            };

            return View(viewModel);
        }




        public List<Session> FindByYear(string year)
        {
            return _unitOfWork.Sessions.FindByYear(year);
        }
        [HttpGet]
        public async Task<IActionResult> Update(string Year)
        {

            IEnumerable<Session> session = await _unitOfWork.Sessions.FindAllAsync(s => s.IsActive == true && s.IsDeleted == false && s.Year == Year, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus" });

            if (session == null)
            {
                return NotFound();

            }

            SessionViewModel sessionViewModel = new SessionViewModel();

            List<SessionViewModel> sessionsViewModel = new List<SessionViewModel>();

            foreach (Session session1 in session)
            {
                sessionsViewModel.Add(MapSessionToViewModel(session1));
            }

            ViewBag.SessionsViewModel = sessionsViewModel;
            ViewBag.Types = _unitOfWork.Lookups.GetAllTypes().ToList();
            ViewBag.Topics = _unitOfWork.Lookups.GetAllTopics().ToList();
            ViewBag.Trainers = _unitOfWork.Lookups.GetAllTrainer().ToList();
            ViewBag.Status = _unitOfWork.Lookups.GetAllStatus().ToList();
            ViewBag.Years = _unitOfWork.Lookups.GetAllYear().ToList();
            ViewBag.Results = _unitOfWork.Lookups.GetAllResults().ToList();

            return View(sessionViewModel);

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


        public async Task<IActionResult> UpdateSession(int Id)
        {
            var session = await _unitOfWork.Sessions.FindAsync(s => s.SessionId == Id, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus" });
            SessionViewModel viewModel = await MapSessionToViewModelWithAll(session);
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSession(SessionViewModel UpdatedSession)
        {

            if (ModelState.IsValid)
            {
                Session afterUpdate = MapViewModelToSession(UpdatedSession);
                afterUpdate.ModifyBy = this.User.Identity.Name;
                afterUpdate.ModifyOn = DateTime.Now;

                afterUpdate.CreatedBy = this.User.Identity.Name;
                afterUpdate.IsActive = true;
                _unitOfWork.Sessions.Update(afterUpdate);
                await _unitOfWork.Complete();
            }

            return RedirectToAction("Index");
        }

    }
}
