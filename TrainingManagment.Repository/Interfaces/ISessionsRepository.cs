using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagment.Domain.Models;

namespace TrainingManagment.Repository.Interfaces
{
    public interface ISessionsRepository : IBaseRepository<Session>
    {
        IEnumerable<Session> OnlyForSession();
        int NumberOfAcceptedTrainees(int Year);
        List<Session> FindByYear(int? Year);
        
    }
}
