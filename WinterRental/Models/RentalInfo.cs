using System.ComponentModel.DataAnnotations;

namespace WinterRental.Models
{
    public class RentalInfo
    {
        [Key]
        public int Id { get; set; } 
        public TimeSpan OpenHour { get; set; } 
        public TimeSpan CloseHour { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(9)]
        public string PhoneNumber { get; set; }
        [MaxLength(255)]
        public string OpenDays { get; set; }
        [MaxLength(255)]
        public string Email { get; set; } 

    
        public ICollection<Worker> Workers { get; set; } 
        public ICollection<User> Users { get; set; }
        public List<Equipment> Equipment { get; internal set; }
        public List<Order> Orders { get; internal set; }
    }
}
