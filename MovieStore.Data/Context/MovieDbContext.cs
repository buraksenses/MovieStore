using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Entities;

namespace MovieStore.Data.Context;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
        
    }

    public DbSet<Actor> Actors { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Director> Directors { get; set; }

    public DbSet<Movie> Movies { get; set; }

    public DbSet<Order> Orders { get; set; }
}