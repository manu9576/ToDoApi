﻿using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
           : base(options)
        {
        }

        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
