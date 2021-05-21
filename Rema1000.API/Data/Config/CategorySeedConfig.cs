using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rema1000.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.API.Data.Config
{
    public class CategorySeedConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Mejeri",
                    Desc = "Mejeri produkter, såsom mælk, ost, fløde osv."
                },
                new Category
                {
                    Id = 2,
                    Name = "Læskedrikke",
                    Desc = "Vand, Sodavand, Øl, Energidrikke m.m."
                },
                new Category
                {
                    Id = 3,
                    Name = "Brød",
                    Desc = "Rugbrød, toastbrød, franskbrød m.m."
                }
            );
        }
    }
}
