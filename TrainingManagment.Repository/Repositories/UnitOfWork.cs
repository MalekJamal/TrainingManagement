using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Repository.Interfaces;
using TrainingManagement.Domain.Models;
using TrainingManagement.Repository.Data;
using TrainingManagement.Repository.Repositories;

namespace TrainingManagement.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Session> Sessions { get; private set; }
        // add more interfaces

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Sessions = new BaseRepository<Session>(_context);
        }


        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        
    }
}
