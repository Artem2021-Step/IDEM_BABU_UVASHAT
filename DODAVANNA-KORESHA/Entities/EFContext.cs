﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeViewAddElement.Entities
{
    public class EFContext : DbContext
    {
        public DbSet<TreeViewCategoryElement> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=denysdb;Username=denys;Password=qwerty1*;");
        }
    }
}
