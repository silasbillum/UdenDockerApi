using Microsoft.EntityFrameworkCore;
using System;
using UdenDockerApi.Models;
using UdenDockerApi.Controllers;

namespace UdenDockerApi.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
