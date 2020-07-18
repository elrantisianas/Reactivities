﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(new Value
            {
                Id = 1,
                Name = "Anas Alrantisi"
            },
            new Value
            {
                Id = 2,
                Name = "Value 102"
            },
            new Value
            {
                Id = 3,
                Name = "Value 103"
            }
            );
        }
    }
}