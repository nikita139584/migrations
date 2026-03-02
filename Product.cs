namespace ConsoleApp1.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; } // Foreign Key
        public Category? Category { get; set; } // navigation property
    }
}
