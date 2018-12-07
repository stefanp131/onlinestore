using OnlineStore.DAL.Entities;
using System.Collections.Generic;

namespace OnlineStore.DAL.Repository
{
    public interface IStoreRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category entity);
        void Save();
    }
}
