namespace _13._2._1_Web_API.Models
{
    public enum Condition
    {
        New,
        Used,
        Refurbished
    }

    public enum Category
    {
        Hardware,
        Components,
        Software,
        Accessories
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public Condition Condition { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

