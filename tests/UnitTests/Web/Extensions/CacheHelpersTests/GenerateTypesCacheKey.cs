﻿using FarmFresh.Web.Extensions;
using Xunit;

namespace FarmFresh.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateTypesCacheKey
    {
        [Fact]
        public void ReturnsTypesCacheKey()
        {
            var result = CacheHelpers.GenerateTypesCacheKey();

            Assert.Equal("types", result);
        }
    }
}
