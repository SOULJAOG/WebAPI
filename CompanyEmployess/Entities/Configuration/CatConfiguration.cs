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
    public class CatConfiguration : IEntityTypeConfiguration<Cat>
    {
        public void Configure(EntityTypeBuilder<Cat> builder)
        {
            builder.HasData
            (
            new Cat
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
                Name = "Nick",
                Gender = "Male",
                Couple = "Scotsman",
            },
            new Cat
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Name = "Tim",
                Gender = "Female",
                Couple = "Sphinx",
            },
            new Cat
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Name = "O'Neill",
                Gender = "Male",
                Couple = "Maine Coon",
            });
        }
    }
}
