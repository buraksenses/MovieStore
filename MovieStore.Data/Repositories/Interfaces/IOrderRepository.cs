﻿using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Interfaces.Base;

namespace MovieStore.Data.Repositories.Interfaces;

public interface IOrderRepository : IGenericRepository<Order, int>
{
    
}