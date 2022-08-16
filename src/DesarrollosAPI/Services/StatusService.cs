using DesarrollosAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesarrollosAPI.Services
{
    public class StatusService:IStatusService
    {
        private readonly DevelopmentContext _dbContext;
        public StatusService(DevelopmentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Status Create(string name)
        {
            Status status = new()
            {
                Name = name
            };
            _dbContext.Statuses.Add(status);
            _dbContext.SaveChanges();
            return status;
        }
        public Status GetById(int id)
        {
            var search = _dbContext.Statuses.First(status => status.Id == id);
            return search;
        }
        public IEnumerable<Status> GetAll()
        {
            return _dbContext.Statuses.ToList();
        }
        public Status Update(int id, string name)
        {
            var status = GetById(id);
            status.Name = name;
            _dbContext.SaveChanges();
            return status;
        }
        public Status Delete(int id)
        {
            var status = GetById(id);
            _dbContext.Statuses.Remove(status);
            _dbContext.SaveChanges();
            return status;
        }
    }
}
