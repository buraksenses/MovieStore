using MovieStore.Data.Entities.Base;

namespace MovieStore.Data.Entities;

public class Order : IEntity<int>
{
    public int Id { get; set; }
    public Customer Customer { get; set; } 
    public Movie Movie { get; set; } 
    public decimal Price { get; set; } 
    public DateTime PurchaseDate { get; set; } 
}