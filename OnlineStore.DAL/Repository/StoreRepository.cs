using OnlineStore.DAL.Context;

namespace OnlineStore.DAL.Repository
{
    public class StoreRepository: IStoreRepository
    {
        private readonly StoreContext context;

        public StoreRepository(StoreContext context)
        {
            this.context = context;
        }
    }
}
