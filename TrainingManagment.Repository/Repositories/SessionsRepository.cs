using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagment.Repository.Interfaces;
using TrainingManagment.Domain.Models;
using TrainingManagment.Repository.Data;
using System.Linq;
using TrainingManagment.Domain.Models.Enums;

namespace TrainingManagment.Repository.Repositories
{
    public class SessionsRepository : BaseRepository<Session>, ISessionsRepository
    {
        private readonly ApplicationDbContext _context;

        public SessionsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Session> OnlyForSession()
        {
            throw new NotImplementedException();
        }

        public int NumberOfAcceptedTrainees(int Year)
        {

            ////???
            var Trainees = FindByYear(Year).Where(x => (int)x.Result == (int)LookupEnum.Result.Joining_TPS_Team).Count();
            return Trainees;
        }

        public int NumberOfTrainees(int Year)
        {
            int numberOfTrainees = FindByYear(Year).Count();
            return numberOfTrainees;
        }


        public List<Session> FindByYear(int? Year)
        {
            List<Session> list = new List<Session>();

            list = _context.Session.Where(x => (int)x.Year == Year && x.IsActive == true).ToList();

            return list;
        }


        public List<Lookup> GetAllTopics()
        {
            List<Lookup> Topics = new List<Lookup>();

            Topics = _context.Lookup.Where(x => x.LookupCategory.Code == 200).ToList();
            //   _context.Sessions.Where(a => a.TrainerName.Code == (int)LookupEnum.Trainer.ZakariaLafi );
            return Topics;
        }

        public List<Lookup> GetAllTypes()
        {
            List<Lookup> Types = new List<Lookup>();

            Types = _context.Lookup.Where(x => x.LookupCategory.Code == 100).ToList();

            return Types;
        }

        public List<Lookup> GetAllTrainers()
        {
            List<Lookup> Trainers = new List<Lookup>();

            Trainers = _context.Lookup.Where(x => x.LookupCategory.Code == 500).ToList();

            return Trainers;
        }

        public List<Lookup> GetAllStatus()
        {
            List<Lookup> Status = new List<Lookup>();

            Status = _context.Lookup.Where(x => x.LookupCategory.Code == 300).ToList();

            return Status;
        }

        public List<Lookup> GetAllResults()
        {
            List<Lookup> Results = new List<Lookup>();

            Results = _context.Lookup.Where(x => x.LookupCategory.Code == 400).ToList();

            return Results;
        }
    }
}
