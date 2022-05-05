#nullable enable
using System.ComponentModel.DataAnnotations;
namespace Cars.Models
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public string? Info { get; set; }
        public List<Car> Cars = new();
    }
}
