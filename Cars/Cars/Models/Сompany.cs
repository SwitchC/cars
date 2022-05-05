#nullable enable
using System.ComponentModel.DataAnnotations;
namespace Cars.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public int Year { get; set; }
        public string Country { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public List<Car> Cars = new(); 
        public List<Dealer> Dealers = new();
    }
}
