using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime deadLineDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }

        //un projecto solo puede tener un status
        [ForeignKey("Status")]
        public int Fk_StatusId { get; set; }
        public Status Status { get; set; }

        //un proyecto solo puede tener una compania


    }
}
