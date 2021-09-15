﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmFresh.ApplicationCore.Entities.BasketAggregate;

namespace FarmFresh.Infrastructure.Data.Config
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(Basket.Items));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(b => b.BuyerId)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
