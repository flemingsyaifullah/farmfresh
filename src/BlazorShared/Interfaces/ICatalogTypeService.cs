using Config.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Config.Interfaces
{
    public interface ICatalogTypeService
    {
        Task<List<CatalogType>> List();
        Task<CatalogType> GetById(int id);
    }
}
