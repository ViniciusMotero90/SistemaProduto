using Microsoft.EntityFrameworkCore;
using SilkRoad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilkRoad.Date
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        {}

        public DbSet<Product> Products { get; set; }
    }
}