using System;
using Microsoft.EntityFrameworkCore;

namespace DatabaseModels
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<List> Lists { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
