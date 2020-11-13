using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tesoro.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers {get; set;}
         public DbSet<Treasure> Treasures {get; set;}
          public DbSet<Coordinate> Coordinates {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
           protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("Users");
                entityTypeBuilder.Property(u => u.UId).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Name).HasMaxLength(100);
                entityTypeBuilder.Property( u => u.Color).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
        }
    }

    public class AppUser : IdentityUser
    {
        public Guid UId{ get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        
    }

    public class Treasure
    {
        public Guid Uid {get; set;}
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public DateTime Date {get; set;}
        public float Weigth {get; set;}
        public string Place {get; set;}
        public float Value {get; set;}
        public Coordinate Coordinates {get; set;}
        public string UrlRef {get; set;}
    }

    public class Coordinate 
    {
        public Guid Id {get; set;}
        public Guid Tid {get; set;}
        public Guid Uid {get; set;}
        public float Lat {get; set;}
        public float Lng {get; set;}
    }

}