using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_13._1.Models
{
    public enum Condition
    {
        New,
        Used,
        [Display(Name = "Certified Refurbished")]
        Refurbished
    }

    public enum Category
    {
        [Display(Name = "Internal Hardware")]
        Hardware,
        [Display(Name = "External Components")]
        Components,
        Software,
        Accessories
    }

    public class Product
    {
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Required]
        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
