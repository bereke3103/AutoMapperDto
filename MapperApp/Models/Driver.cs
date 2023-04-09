using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MapperApp.Models
{
    public class Driver
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DriverNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public int Status { get; set; }
        public int WorldChampionShips { get; set; }
    }
}
