using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Domain.Models;

namespace TrainingManagement.Repository.Interfaces
{
    public interface ISessionsRepository : IBaseRepository<Session>
    {
        IEnumerable<Session> OnlyForSession();
    }
}
