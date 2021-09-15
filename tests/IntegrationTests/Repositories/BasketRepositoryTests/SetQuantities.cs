﻿using Microsoft.EntityFrameworkCore;
using FarmFresh.ApplicationCore.Entities.BasketAggregate;
using FarmFresh.ApplicationCore.Interfaces;
using FarmFresh.ApplicationCore.Services;
using FarmFresh.Infrastructure.Data;
using FarmFresh.UnitTests.Builders;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace FarmFresh.IntegrationTests.Repositories.BasketRepositoryTests
{
    public class SetQuantities
    {
        private readonly CatalogContext _catalogContext;
        private readonly IAsyncRepository<Basket> _basketRepository;
        private readonly BasketBuilder BasketBuilder = new BasketBuilder();

        public SetQuantities()
        {
            var dbOptions = new DbContextOptionsBuilder<CatalogContext>()
                .UseInMemoryDatabase(databaseName: "TestCatalog")
                .Options;
            _catalogContext = new CatalogContext(dbOptions);
            _basketRepository = new EfRepository<Basket>(_catalogContext);
        }

        [Fact]
        public async Task RemoveEmptyQuantities()
        {
            var basket = BasketBuilder.WithOneBasketItem();
            var basketService = new BasketService(_basketRepository, null);
            await _basketRepository.AddAsync(basket);
            _catalogContext.SaveChanges();

            await basketService.SetQuantities(BasketBuilder.BasketId, new Dictionary<string, int>() { { BasketBuilder.BasketId.ToString(), 0 } });

            Assert.Equal(0, basket.Items.Count);
        }
    }
}