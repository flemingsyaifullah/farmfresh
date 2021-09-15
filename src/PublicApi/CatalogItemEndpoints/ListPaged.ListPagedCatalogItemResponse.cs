using System;
using System.Collections.Generic;

namespace FarmFresh.PublicApi.CatalogItemEndpoints
{
    public class ListPagedCatalogItemResponse : BaseResponse
    {
        public ListPagedCatalogItemResponse(Guid correlationId) : base(correlationId)
        {
        }

        public ListPagedCatalogItemResponse()
        {
        }

        public List<CatalogItemDto> CatalogItems { get; set; } = new List<CatalogItemDto>();
        public int PageCount { get; set; }
    }
}
