﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovie.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcMovie.DAL
{
    
        public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, MvcMovie.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        }
    }