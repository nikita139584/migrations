namespace ConsoleApp1.Models
{
    public class Order
    {
        public int Id { get; set; } // первинний ключ
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        // зовнішній ключ + навігаційна властивість (зв'язок з User)
        public int UserId { get; set; }            // обов'язково!
        public User User { get; set; } = null!;    // навігаційна властивість (опціонально, але дуже зручно)
    }
}
