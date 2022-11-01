using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class ContentOfOrderConfiguration : IEntityTypeConfiguration<ContentOfOrder>
    {
        public void Configure(EntityTypeBuilder<ContentOfOrder> builder)
        {
            builder.HasData
            (
            new ContentOfOrder
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
                OrderId = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
                Product = "Shirt",
                Price = "1500",
                Quantity = "1",
                Cost = "1500",
            },
            new ContentOfOrder
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                OrderId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Product = "T-shirt",
                Price = "1000",
                Quantity = "1",
                Cost = "1000",
            },
            new ContentOfOrder
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                OrderId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Product = "Down Jacket",
                Price = "3000",
                Quantity = "1",
                Cost = "3000",
            });
        }
    }
}
