using Microsoft.EntityFrameworkCore;
using FarmFresh.ApplicationCore.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmFresh.Infrastructure.Data
{
    public class CatalogContextSeed
    {
        public static async Task SeedAsync(CatalogContext catalogContext,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                // TODO: Only run this if using a real database
                //catalogContext.Database.Migrate();
                if (catalogContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                {
                    catalogContext.Database.Migrate();
                }
                if (!await catalogContext.CatalogBrands.AnyAsync())
                {
                    await catalogContext.CatalogBrands.AddRangeAsync(
                        GetPreconfiguredCatalogBrands());

                    await catalogContext.SaveChangesAsync();
                }

                if (!await catalogContext.CatalogTypes.AnyAsync())
                {
                    await catalogContext.CatalogTypes.AddRangeAsync(
                        GetPreconfiguredCatalogTypes());

                    await catalogContext.SaveChangesAsync();
                }

                if (!await catalogContext.CatalogItems.AnyAsync())
                {
                    await catalogContext.CatalogItems.AddRangeAsync(
                        GetPreconfiguredItems());

                    await catalogContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<CatalogContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(catalogContext, loggerFactory, retryForAvailability);
                }
                throw;
            }
        }

        static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand("Type 1"),
                new CatalogBrand("Type 2"),
                new CatalogBrand("Type 3"),
                new CatalogBrand("Type 4"),
                new CatalogBrand("Other")
            };
        }

        static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType("Type 5"),
                new CatalogType("Type 6"),
                new CatalogType("Type 7"),
                new CatalogType("Type 8")
            };
        }

        static IEnumerable<CatalogItem> GetPreconfiguredItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem(2,2, "Fruit 1", "Fruit 1", 21,  "http://catalogbaseurltobereplaced/images/products/1.png"),
                new CatalogItem(1,2, "Fruit 2", "Fruit 2", 19, "http://catalogbaseurltobereplaced/images/products/2.png"),
                new CatalogItem(2,5, "Fruit 3", "Fruit 3", 15,  "http://catalogbaseurltobereplaced/images/products/3.png"),
                new CatalogItem(2,2, "Fruit 4", "Fruit 4", 15, "http://catalogbaseurltobereplaced/images/products/4.png"),
                new CatalogItem(3,5, "Fruit 5", "Fruit 5", 16, "http://catalogbaseurltobereplaced/images/products/5.png"),
                new CatalogItem(2,2, "Fruit 6", "Fruit 6", 13, "http://catalogbaseurltobereplaced/images/products/6.png"),
                new CatalogItem(2,5, "Fruit 7", "Fruit 7",  12, "http://catalogbaseurltobereplaced/images/products/7.png")
            };
        }
    }
}
