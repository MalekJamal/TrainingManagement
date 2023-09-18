using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingManagment.Domain.Models;

namespace TrainingManagment.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // here to add all the models
        //IBaseRepository<Session> Sessions { get; }

        // here if I need to use the ISessionsRepo
        ISessionsRepository Sessions { get; }
        ILookupRepository Lookups { get; }


        Task<int> Complete();
    }
}
