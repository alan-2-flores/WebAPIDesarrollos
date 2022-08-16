using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesarrollosAPI.Models
{
    public class Status
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        //Un status puede tener muchos proyectos
        public ICollection<Project> FK_Projects { get; set; }
    }
}
