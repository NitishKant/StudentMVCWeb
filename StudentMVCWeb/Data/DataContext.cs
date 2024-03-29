﻿using Microsoft.EntityFrameworkCore;
using StudentMVCWeb.Models;

namespace StudentMVCWeb.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }

        public DbSet<Book> Book { get; set; }
    }
}
