﻿using micro1.Models;
using Microsoft.EntityFrameworkCore;

namespace micro1.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
