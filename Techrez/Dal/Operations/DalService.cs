﻿using Common;
using Dal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public partial class DalService : IDalService
    {
        private TechrezDbContext DbContext;

        public DalService(TechrezDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }

    public interface IDalService
    {
        Task<List<Product>> GetProductsAsync(SearchSetting searchSetting);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> UpdateProductAsync(Product product);
        Task<int> AddProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<Category>> GetCategoriesAsync();
        void InitData();
    }
}
