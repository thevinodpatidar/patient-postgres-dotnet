﻿using System;
using Microsoft.EntityFrameworkCore;
using Patients.Models;

namespace Patients.DataAccess
{
    public class PostgreSqlContext :DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {

        }

        public DbSet<Patient> patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
