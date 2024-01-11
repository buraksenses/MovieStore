using MovieStore.Data.Entities.Base;

namespace MovieStore.Data.Entities;

public class Customer : IEntity<int>
{
    public int Id { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public ICollection<Order> Orders { get; set; }
}