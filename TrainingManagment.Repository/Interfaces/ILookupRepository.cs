using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagment.Domain.Models;

namespace TrainingManagment.Repository.Interfaces
{
    public interface ILookupRepository : IBaseRepository<Lookup>
    {
        // any method need to be added for the Lookup specially should be add here and implemented in LookupRepository

        public List<Lookup> GetAllTopics();

        public List<Lookup> GetAllTypes();

        public List<Lookup> GetAllStatus();

        public List<Lookup> GetAllResults();

        public List<Lookup> GetAllYear();

        public List<Lookup> GetAllTrainer();

    }
}
