using System.ComponentModel.DataAnnotations;

namespace WinterRental.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Rented_Items { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        public decimal price { get; set; }
        [Required]
        public DateOnly Date_Of_submission { get; set; }
        [Required]
        public Boolean Was_It_Returned { get; set; }  
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();



    }
}
