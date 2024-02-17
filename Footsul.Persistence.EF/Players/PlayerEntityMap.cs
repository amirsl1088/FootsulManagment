using Footsul.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Persistence.EF.Players
{
    public class PlayerEntityMap : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.FirstName).HasMaxLength(50);
            builder.Property(_ => _.LastName).HasMaxLength(50);
            builder.Property(_ => _.BirthDay).IsRequired();
        }
    }
}
