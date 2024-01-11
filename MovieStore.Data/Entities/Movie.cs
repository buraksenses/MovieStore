using MovieStore.Data.Entities.Base;

namespace MovieStore.Data.Entities;

public class Movie : IEntity<int>
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public int Year { get; set; } 
    public string Genre { get; set; } 
    public Director Director { get; set; }
    public ICollection<Actor> Actors { get; set; } 
    public decimal Price { get; set; }
}