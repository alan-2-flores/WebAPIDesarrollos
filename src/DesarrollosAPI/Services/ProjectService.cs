using DesarrollosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesarrollosAPI.Services
{
    public class ProjectService:IProjectService
    {
        private readonly DevelopmentContext _dbContext;
        public ProjectService(DevelopmentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Project Create(string name, string description, DateTime startDate, DateTime deadLineDate, DateTime endDate)
        {
            Project project = new()
            {
                Name = name,
                Description = description,
                startDate = startDate.Date,
                deadLineDate = deadLineDate.Date,
                endDate = endDate.Date
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
            project.startDate = startDate.Date;
            project.deadLineDate = deadLineDate.Date;
            project.endDate = endDate.Date;
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
