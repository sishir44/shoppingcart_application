﻿using BookShoppingCartMvcUI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookShoppingCartMvcUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
      
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
