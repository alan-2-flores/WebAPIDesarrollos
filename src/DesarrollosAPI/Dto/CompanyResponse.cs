namespace DesarrollosAPI.Dto
{
    public class CompanyResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public CompanyResponse(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
