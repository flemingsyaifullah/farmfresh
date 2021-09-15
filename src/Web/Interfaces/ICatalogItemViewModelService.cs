using FarmFresh.Web.ViewModels;
using System.Threading.Tasks;

namespace FarmFresh.Web.Interfaces
{
    public interface ICatalogItemViewModelService
    {
        Task UpdateCatalogItem(CatalogItemViewModel viewModel);
    }
}
