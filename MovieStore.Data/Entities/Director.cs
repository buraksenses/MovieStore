using MovieStore.Data.Entities.Base;

namespace MovieStore.Data.Entities;

public class Director : IEntity<int>
{
    public int Id { get; set; }
    public string FirstName { get; set; } // İsim
    public string LastName { get; set; } // Soyisim
    public ICollection<Movie> DirectedMovies { get; set; }
}