using System.Collections.Generic;
using System.Threading.Tasks;
using Config.Models;

namespace Config.Interfaces
{
    public interface ICatalogBrandService
    {
        Task<List<CatalogBrand>> List();
        Task<CatalogBrand> GetById(int id);
    }
}
