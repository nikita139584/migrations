namespace ConsoleApp1.Models
{
	public class Review
	{
		public int Id { get; set; } // Primary Key

		public string? Comment { get; set; } 
		public int Rating { get; set; } 

		public DateTime CreatedAt { get; set; } 

		public int ProductId { get; set; } // Foreign Key
		public Product? Product { get; set; } // navigation property
	}
}