using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public enum Name
    {
        OnProcess,
        Pending,
        Canceled,
        Finalized,
        Paused
    }
    public class Status
    {
        [Required]
        public int Id { get; set; }
        public Name Name { get; set; }
        //Un status puede tener muchos proyectos
        public ICollection<Project> FK_Projects { get; set; }
    }
}
