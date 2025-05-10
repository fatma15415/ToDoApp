using System.Collections.Generic;
using System;
using ToDoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Context
{
    public class ToDoContext : DbContext
{
    
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems { get; set; }
}
}
