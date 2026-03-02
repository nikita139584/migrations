using ConsoleApp1.Infrastructure;
using ConsoleApp1.Infrastructure.Repositories;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var context = new AppDbContext();
            context.Database.Migrate(); // dotnet ef database update

            var repo = new UserRepository(context);

            repo.AddUsers(new List<User>
            {
                new User { Name = "Alice", Age = 44 },
                new User { Name = "Bob", Age = 44 },
                new User { Name = "Charlie", Age = 44 }
            });

            repo.ShowAllUsers(); // показуємо усіх користувачів
        }
    }
}