using DesarrollosAPI.Models;
using System.Collections.Generic;

namespace DesarrollosAPI.Services
{
    public interface IStatusService
    {
        Status Create(string name);
        Status GetById(int id);
        IEnumerable<Status> GetAll();
        Status Update(int id, string name);
        Status Delete(int id);
    }
}
