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
                    Desc = "Arla mejeri produkter og produktion.",
                    
                    ContactPerson = "Kim Larsen",
                    Address = "Slagelsevej 31",
                    Email = "kl@arla.dk",
                    PhoneNumber = 31557522,
                    PostalCode = 4200
                },
                new Supplier
                {
                    Id = 2,
                    Name = "Schulstad",
                    Desc = "Brød, brød og brød.",

                    ContactPerson = "Lars Torsten",
                    Address = "Horsensvej 22",
                    Email = "lt@schulstad.dk",
                    PhoneNumber = 54213244,
                    PostalCode = 7100
                },
                new Supplier
                {
                    Id = 3,
                    Name = "Royal Unibrew",
                    Desc = "Produktion af Sodavand, øl og andre læskedrikke.",

                    ContactPerson = "Frederik Jensen",
                    Address = "Faxevej",
                    Email = "fj@royalunibrew.dk",
                    PhoneNumber = 61732233,
                    PostalCode = 2200
                }
            );
        }
    }
}
