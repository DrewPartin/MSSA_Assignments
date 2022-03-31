using System.ComponentModel.DataAnnotations;
namespace Assignment_12._3.Models
{
    public enum Condition
    {
        New,
        Used,
        [Display(Name = "Certified Refurbished")]
        Refurbished
    }

    public class Product
    {
        [Required]
        [Display(Name = "Product ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        public string ImageName { get; set; }

        [Required]
        public Condition Condition { get; set; }
    }
}
