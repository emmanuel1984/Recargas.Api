﻿using Pedidos.Api.Data.Context;

namespace Pedidos.Api.Data.Repository
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
