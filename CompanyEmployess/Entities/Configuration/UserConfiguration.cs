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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
            new User
            {
<<<<<<< HEAD:CompanyEmployess/Entities/Configuration/UserConfiguration.cs
                Id = new Guid("80abbca8-664d-4b20-b5de-024715497d4a"),
                Mail = "nick@gmail.com",
=======
                Id = new Guid("80abbca8-664d-4b29-b5de-124715497d4a"),
                Name = "Nick",
                Gender = "Male",
                Couple = "Scotsman",
>>>>>>> aef9d58cbf25c431223056766df7d4e832365b72:CompanyEmployess/Entities/Configuration/CatConfiguration.cs
            },
            new User
            {
<<<<<<< HEAD:CompanyEmployess/Entities/Configuration/UserConfiguration.cs
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Mail = "tim@gmail.com",
=======
                Id = new Guid("86dba8c0-d178-41e6-938c-ed49678fb52a"),
                Name = "Tim",
                Gender = "Female",
                Couple = "Sphinx",
>>>>>>> aef9d58cbf25c431223056766df7d4e832365b72:CompanyEmployess/Entities/Configuration/CatConfiguration.cs
            },
            new User
            {
<<<<<<< HEAD:CompanyEmployess/Entities/Configuration/UserConfiguration.cs
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Mail = "oneill@gmail.com",
=======
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8379811"),
                Name = "O'Neill",
                Gender = "Male",
                Couple = "Maine Coon",
>>>>>>> aef9d58cbf25c431223056766df7d4e832365b72:CompanyEmployess/Entities/Configuration/CatConfiguration.cs
            });
        }
    }
}
