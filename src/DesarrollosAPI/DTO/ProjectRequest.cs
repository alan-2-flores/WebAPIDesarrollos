using System;
using System.ComponentModel.DataAnnotations;

namespace DesarrollosAPI.DTO
{
    public class ProjectRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeadLineDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public ProjectRequest()
        {
        }
    }
}
