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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData
            (
            new Order
            {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),          
=======
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
>>>>>>> lab4
=======
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
>>>>>>> lab5
=======
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
>>>>>>> lab6
                CustomerName = "Raiden",
                Phone = "89278976365",
                DateOfDelivery = new DateTime(),
                DateOfIssue = new DateTime(),
            },
            new Order
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                CustomerName = "Miller",
                Phone = "89278876365",
                DateOfDelivery = new DateTime(),
                DateOfIssue = new DateTime(),
            },
            new Order
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                CustomerName = "Nill",
                Phone = "89278876345",
                DateOfDelivery = new DateTime(),
                DateOfIssue = new DateTime(),
            });
        }
    }
}
