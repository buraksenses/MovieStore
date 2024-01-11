namespace MovieStore.Data.Entities.Base;

public interface IEntity<TKey>
{
    public TKey Id { get; set; }
}