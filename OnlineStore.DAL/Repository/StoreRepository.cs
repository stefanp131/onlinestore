using System.Collections.Generic;
using System.Linq;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repository
{
    public class StoreRepository: IStoreRepository
    {
        private readonly StoreContext context;

        public StoreRepository(StoreContext context)
        {
            this.context = context;
        }

        public void AddCategory(Category entity)
        {
            context.Categories.Add(entity);
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
