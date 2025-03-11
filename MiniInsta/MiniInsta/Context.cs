using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MiniInsta;

internal class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public Context()
    {
        Database.EnsureCreated();
    }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("jsconfig1.json");
        var config = builder.Build();

        string connectionString = config.GetConnectionString("MyJsonCS");
        optionsBuilder.UseSqlServer(connectionString);
    }
}
