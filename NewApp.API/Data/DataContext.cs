﻿using Microsoft.EntityFrameworkCore;
using NewApp.API.Models;
using NewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {  }

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
