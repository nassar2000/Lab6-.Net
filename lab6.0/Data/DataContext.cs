using API.Entities;
using Microsoft.EntityFrameworkCore;
using SeedingProdoct.Helper;
using System;



namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.seed();
            //    .Property(s => s.ToDoName).IsRequired().HasMaxLength(100);
            //base.OnModelCreating(modelBuilder);
        }
    }
}