using Ardalis.Specification;
using FarmFresh.ApplicationCore.Entities;
using System;
using System.Linq;

namespace FarmFresh.ApplicationCore.Specifications
{
    public class CatalogItemsSpecification : Specification<CatalogItem>
    {
        public CatalogItemsSpecification(params int[] ids)
        {
            Query.Where(c => ids.Contains(c.Id));
        }
    }
}
