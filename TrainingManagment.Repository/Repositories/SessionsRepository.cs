using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagment.Repository.Interfaces;
using TrainingManagment.Domain.Models;
using TrainingManagment.Repository.Data;
using System.Linq;
using TrainingManagment.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace TrainingManagment.Repository.Repositories
{
    public class SessionsRepository : BaseRepository<Session>, ISessionsRepository
    {
        private readonly ApplicationDbContext _context;

        public SessionsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Session> GetSessionByYear(string year)
        {
            return (_context.Session.Where(x => x.Year == year).ToList());

        }

        public int NumberOfTrainees(string year)
        {
            int number = _context.Session.Where(x => x.Year == year && x.IsActive == true).Count();

            return number;
        }

        public int NumberOfAcceptedTrainees(string Year)
        {

            //  var Trainees =  _context.Session.Where(x => x.enResult == LookupEnum.Result.On_Hold|| x.enResult == LookupEnum.Result.Joining_TPS_Team && x.Year==Year).Count();
            //return Trainees;
            return 5;
        }

        public bool IsYearExist(string year)
        {
            var exist = _context.Session.Where(x => x.Year == year);
            return exist.Any();
        }

        public List<Session> FindByYear(string year)
        {
            // this is a way to return the session with corresponding columns in lookup tables
            var sessions = _context.Session
                .Include(s => s.TrainerName)
                .Include(s => s.TrainingType)
                .Include(s => s.TrainingTopic)
                .Include(s => s.TrainingStatus)
                .ToList();

            return (sessions);
        }
    }
}