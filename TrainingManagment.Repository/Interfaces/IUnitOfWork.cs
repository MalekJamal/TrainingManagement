using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Domain.Models;

namespace TrainingManagement.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // here to add all the models
        //IBaseRepository<Session> Sessions { get; }

        // here if I need to use the ISessionsRepo
        ISessionsRepository Sessions { get; }


        Task<int> Complete();
    }
}
