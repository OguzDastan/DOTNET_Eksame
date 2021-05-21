using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rema1000.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.API.Data.Config
{
    public class ProductSeedConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Pepsi Max",
                    Desc = "Sukkerfri Cola!",


                    Unit = 1.5,
                    Amount = 1,
                    Price = 15.95,
                    Stock = 500,

                    CategoryId = 2,
                    SupplierId = 3,
                }, 
                new Product
                {
                    Id = 2,
                    Name = "Heineken",
                    Desc = "Øl med 1.5% alkohol!",


                    Unit = 0.33,
                    Amount = 6,
                    Price = 36.95,
                    Stock = 150,

                    CategoryId = 2,
                    SupplierId = 3,
                },

                new Product
                {
                    Id = 3,
                    Name = "Rugbrød",
                    Desc = "Rugbrød med store kerner.",


                    Unit = 0.2,
                    Amount = 1,
                    Price = 11.95,
                    Stock = 50,

                    CategoryId = 3,
                    SupplierId = 2,
                },
                new Product
                {
                    Id = 4,
                    Name = "Sandwhichbrød",
                    Desc = "Sundt brød!",


                    Unit = 0.5,
                    Amount = 1,
                    Price = 20.95,
                    Stock = 25,

                    CategoryId = 3,
                    SupplierId = 2,
                },

                new Product
                {
                    Id = 5,
                    Name = "Sødmælk",
                    Desc = "Mælk du kan drikke.",


                    Unit = 1,
                    Amount = 1,
                    Price = 8.95,
                    Stock = 100,

                    CategoryId = 1,
                    SupplierId = 1,
                },
                new Product
                {
                    Id = 6,
                    Name = "Ost",
                    Desc = "Ost til din madpakke.",


                    Unit = 0.2,
                    Amount = 1,
                    Price = 22.95,
                    Stock = 300,

                    CategoryId = 1,
                    SupplierId = 1,
                },
                new Product
                {
                    Id = 7,
                    Name = "Kakao",
                    Desc = "Kakao du kan drikke.",


                    Unit = 1,
                    Amount = 1,
                    Price = 16.95,
                    Stock = 500,

                    CategoryId = 2,
                    SupplierId = 1,
                },
                new Product
                {
                    Id = 8,
                    Name = "Arla Brød",
                    Desc = "Nyt fra Arla, de kan også lave brød!",


                    Unit = 1,
                    Amount = 1,
                    Price = 24.95,
                    Stock = 50,

                    CategoryId = 3,
                    SupplierId = 1,
                }



            );
        }
    }
}
