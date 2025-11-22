using System.ComponentModel.DataAnnotations;

namespace WinterRental.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; } 
        public string? size { get; set; }
        [Required]
        public Boolean Is_In_Werehouse { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Price { get; set; }
        public Boolean Is_Reserved { get; set; }
        public ICollection<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();
    }
}
