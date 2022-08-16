using DesarrollosAPI.Models;
using System;
using System.Collections.Generic;

namespace DesarrollosAPI.Services
{
    public interface IProjectService
    {
        Project Create(string name,string description, DateTime startDate, DateTime deadLineDate, DateTime endDate);
        Project GetById(int id);
        IEnumerable<Project> GetAll();
        Project Update(int id, string name, string description, DateTime startDate, DateTime deadLineDate, DateTime endDate);
        Project Delete(int id);
    }
}
