﻿namespace DesarrollosAPI.DTOS
{
    public class ProposalRequestWithId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime StartDate { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime DeadLineDate { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime EndDate { get; set; }

        public ProposalRequestWithId()
        {

        }
    }
}
