using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagment.Domain.Models.Enums;
using TrainingManagment.Domain.Models;
using TrainingManagment.Repository.Data;
using TrainingManagment.Repository.Interfaces;

namespace TrainingManagment.Repository.Repositories
{
    public class LookupRepository : BaseRepository<Lookup>, ILookupRepository
    {
        private readonly ApplicationDbContext _context;

        public LookupRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<string> GetAllResults()
        {
            List<string> results = new List<string>();

            results = _context.Lookup.Where(x => x.LookupCategoryId == (int)LookupEnum.CategoryCode.Results).Select(x => x.NameEn).ToList();

            return results;
        }

        public List<string> GetAllStatus()

        {
            List<string> Status = new List<string>();

            Status = _context.Lookup.Where(x => x.LookupCategoryId == (int)LookupEnum.CategoryCode.Status).Select(x => x.NameEn).ToList();

            return Status;
        }

        public List<Lookup> GetAllTopics()
        {
            List<Lookup> Topics = new List<Lookup>();

            Topics = _context.Lookup.Where(x => x.LookupCategoryId == (int)LookupEnum.CategoryCode.Topics).ToList();

            return Topics;
        }



        public List<Lookup> GetAllTrainer()
        {
            List<Lookup> trainers = new List<Lookup>();

            trainers = _context.Lookup.Where(x => x.LookupCategoryId == (int)LookupEnum.CategoryCode.TrainerName).ToList();

            return trainers;
        }

        public List<Lookup> GetAllTypes()
        {
            List<Lookup> types = new List<Lookup>();

            types = _context.Lookup.Where(x => x.LookupCategoryId == (int)LookupEnum.CategoryCode.Type).ToList();

            return types;
        }

        public List<Lookup> GetAllYear()
        {
            List<Lookup> year = new List<Lookup>();

            year = _context.Lookup.Where(x => x.LookupCategoryId == (int)LookupEnum.CategoryCode.Year).ToList();

            return year;
        }


    }
}
