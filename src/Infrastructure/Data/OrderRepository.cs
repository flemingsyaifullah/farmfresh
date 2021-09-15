using Microsoft.EntityFrameworkCore;
using FarmFresh.ApplicationCore.Entities.OrderAggregate;
using FarmFresh.ApplicationCore.Interfaces;
using System.Threading.Tasks;

namespace FarmFresh.Infrastructure.Data
{
    public class OrderRepository : EfRepository<Order>, IOrderRepository
    {
        public OrderRepository(CatalogContext dbContext) : base(dbContext)
        {
        }

        public Task<Order> GetByIdWithItemsAsync(int id)
        {
            return _dbContext.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.ItemOrdered)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
