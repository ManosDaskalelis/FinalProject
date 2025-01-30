﻿using Project.Models;

namespace Project.Repository.IRepository
{
    public interface ICartRepository
    {
        public Task<bool> UpdateCartAsync(string userId, int product, int updateBy);
        public Task<IEnumerable<Cart>> GetAllAsync(string? userId);
        public Task<bool> ClearCartAsync(string? userId, int productId);
        public Task<int> GetTotalCountAsync(string? userId);
    }
}
