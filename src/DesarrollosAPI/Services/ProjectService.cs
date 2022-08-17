using DesarrollosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesarrollosAPI.Services
{
    public class ProjectService:IProjectService
    {
        private readonly RepositoryContext _dbContext;
        public ProjectService(RepositoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Project Create(string name, string description, DateTime startDate, DateTime deadLineDate, DateTime endDate)
        {
            Project project = new()
            {
                Name = name,
                Description = description,
                StartDate = startDate.Date,
                DeadLineDate = deadLineDate.Date,
                EndDate = endDate.Date
            };
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
            return project;
        }
        public Project GetById(int id)
        {
            var search = _dbContext.Projects.First(project => project.Id == id);
            return search;
        }
        public IEnumerable<Project> GetAll()
        {
            return _dbContext.Projects.ToList();
        }
        public Project Update(int id, string name, string description, DateTime startDate, DateTime deadLineDate, DateTime endDate)
        {
            var project = GetById(id);
            project.Name = name;
            project.Description = description;
            project.StartDate = startDate.Date;
            project.DeadLineDate = deadLineDate.Date;
            project.EndDate = endDate.Date;
            _dbContext.SaveChanges();
            return project;
        }
        public Project Delete(int id)
        {
            var project = GetById(id);
            _dbContext.Projects.Remove(project);
            _dbContext.SaveChanges();
            return project;
        }
    }
}
