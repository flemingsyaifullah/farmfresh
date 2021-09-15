﻿using FarmFresh.Web.Extensions;
using Xunit;

namespace FarmFresh.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateBrandsCacheKey
    {
        [Fact]
        public void ReturnsBrandsCacheKey()
        {
            var result = CacheHelpers.GenerateBrandsCacheKey();

            Assert.Equal("brands", result);
        }
    }
}