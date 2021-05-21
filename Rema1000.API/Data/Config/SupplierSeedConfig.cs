using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rema1000.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.API.Data.Config
{
    public class SupplierSeedConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData(
                new Supplier
                {
                    Id = 1,
                    Name = "Arla",
                    Desc = "Arla mejeri produkter og produktion."
                },
                new Supplier
                {
                    Id = 2,
                    Name = "Schulstad",
                    Desc = "Brød, brød og brød."
                },
                new Supplier
                {
                    Id = 3,
                    Name = "Royal Unibrew",
                    Desc = "Produktion af Sodavand, øl og andre læskedrikke."
                }
            );
        }
    }
}
