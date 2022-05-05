using System.ComponentModel.DataAnnotations;
namespace Cars.Models
{
    public class Dealer
    {
        [Key]
        public int DealerId { get; set; }

        public string Address { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public List<Car> Cars { get; set; }=new();
        public List<Company> Companies { get; set; }=new();
    }
}
