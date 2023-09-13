using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagment.Domain.Models;

namespace TrainingManagment.Repository.Interfaces
{
    public interface ILookup : IBaseRepository<Lookup>
    {


        public List<Lookup> GetAllTopics();

        public List<Lookup> GetAllTypes();

        public List<string> GetAllStatus();

        public List<string> GetAllResults();

        public List<Lookup> GetAllYear();

        public List<Lookup> GetAllTrainer();

    }
}
