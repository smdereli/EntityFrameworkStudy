using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{


    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseNpgsql(@"postgres://postgres:postgrespw@localhost:55000");
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=55002;Database=shopdb;User Id = postgres; Password = postgrespw");
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
    }

    public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}


}