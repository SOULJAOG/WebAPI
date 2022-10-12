using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class DogConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.HasData
            (
            new Dog
            {
                Id = new Guid("80abbca3-664d-4b20-b5de-024715497d4a"),
                Name = "Raiden",
                Gender = "Male",
                Couple = "German Shepherd",
            },
            new Dog
            {
                Id = new Guid("86dba8c1-d178-41e7-938c-ed49778fb52a"),
                Name = "McLeaf",
                Gender = "Female",
                Couple = "Poodle",
            },
            new Dog
            {
                Id = new Guid("021ca3c2-0deb-4afd-ae94-2159a8479811"),
                Name = "Miller",
                Gender = "Male",
                Couple = "German Shepherd",
            });
        }
    }
}
