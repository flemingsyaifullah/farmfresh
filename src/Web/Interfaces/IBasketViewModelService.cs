using FarmFresh.Web.Pages.Basket;
using System.Threading.Tasks;

namespace FarmFresh.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
