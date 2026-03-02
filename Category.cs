namespace ConsoleApp1.Models
{
    public class Category
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }

        public ICollection<Product>? Products { get; set; } // 1 to many
    }
}
