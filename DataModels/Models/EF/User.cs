using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Models.EF
{
    public partial class User
    {
        public Guid? ID { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; private set; }
    }
    public partial class User
    {
        public class Configuration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder
                    .Property(nameof(Age))
                    .HasComputedColumnSql($"DATEDIFF(YEAR, {nameof(BirthDate)}, GETDATE())");
            }
        }
    }
}
