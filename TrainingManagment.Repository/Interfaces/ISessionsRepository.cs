using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagment.Domain.Models;

namespace TrainingManagment.Repository.Interfaces
{
    public interface ISessionsRepository : IBaseRepository<Session>
    {

        int NumberOfTrainees(string year);
        int NumberOfAcceptedTrainees(string Year);
        bool IsYearExist(string year);
        List<Session> FindByYear(string year);
        Session GetSession();

    }
}
