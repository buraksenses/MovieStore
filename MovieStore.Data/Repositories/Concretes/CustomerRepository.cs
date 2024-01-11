using MovieStore.Data.Context;
using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Concretes.Base;
using MovieStore.Data.Repositories.Interfaces;

namespace MovieStore.Data.Repositories.Concretes;

public class CustomerRepository : GenericRepository<Customer, int>, ICustomerRepository
{
    public CustomerRepository(MovieDbContext dbContext) : base(dbContext)
    {
    }

}