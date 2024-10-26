﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Tableconfigs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50).HasColumnType(SqlDbType.VarChar.ToString());
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50).HasColumnType(SqlDbType.VarChar.ToString());
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200).HasColumnType(SqlDbType.VarChar.ToString());
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(200).HasColumnType(SqlDbType.VarChar.ToString());

        }
    }
}