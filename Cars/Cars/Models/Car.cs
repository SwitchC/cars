#nullable enable
using System.ComponentModel.DataAnnotations;
namespace Cars.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        public string Name { get; set; } = null!;

        public int CompanyId { get; set; }
        
        public int DealerId { get; set; }

        public double Price { get; set; }
        
        public string? Info { get; set; }

        public Company Company { get; set; } = null!;
        public Dealer Dealer { get; set; } = null!;
        public List<Detail> Details = new();
    }
}
