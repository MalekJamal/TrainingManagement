using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Repository.Interfaces;
using TrainingManagement.Domain.Models;
using TrainingManagement.Repository.Data;

namespace TrainingManagement.Repository.Repositories
{
    public class SessionsRepository : BaseRepository<Session>, ISessionsRepository
    {
        private readonly ApplicationDbContext _context;

        public SessionsRepository(ApplicationDbContext context): base(context)
        {
            
        }
        public IEnumerable<Session> OnlyForSession()
        {
            throw new NotImplementedException();
        }
    }
}
