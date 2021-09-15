using FarmFresh.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace FarmFresh.ApplicationCore.Interfaces
{

    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<Order> GetByIdWithItemsAsync(int id);
    }
}
