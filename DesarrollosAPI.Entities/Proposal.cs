using System.ComponentModel.DataAnnotations;
//proposals
namespace DesarrollosAPI.Entities
{
    //AUTOMAPER
    public class Proposal
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime StartDate { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime DeadLineDate { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime? EndDate { get; set; }

        //un projecto solo puede tener un status
        //[ForeignKey("Status")]
        //public int Fk_StatusId { get; set; }
        //public Status Status { get; set; }

        //un proyecto solo puede tener una compania


    }
}
