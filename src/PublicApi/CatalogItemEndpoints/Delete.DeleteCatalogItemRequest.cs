using Microsoft.AspNetCore.Mvc;

namespace FarmFresh.PublicApi.CatalogItemEndpoints
{
    public class DeleteCatalogItemRequest : BaseRequest 
    {
        //[FromRoute]
        public int CatalogItemId { get; set; }
    }
}
