using FarmFresh.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace FarmFresh.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId, Address shippingAddress);
    }
}
